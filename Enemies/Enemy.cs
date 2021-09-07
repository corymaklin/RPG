using System;
using System.Collections.Generic;
using _Project.Scripts.Enemies.Animations.Character;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.AI;

namespace _Project.Scripts.Enemies
{
    public class Enemy : MonoBehaviour
    {
        public EnemyDefinition definition;

        private List<Stat> stats;
        
        private Animator animator;
        private NavMeshAgent agent;
        public NavMeshAgent Agent => agent;
        private Transform target;
        public Transform Target => target;
        public event Action<Enemy> OnDied;
        public event Action<int> OnTakeDamage;

        // public float fieldOfVisionAngle = 135f;
        public float fieldOfVisionAngle = 270;
        public float fieldOfVisionRadius = 3f;
        public float patrolDistance = 2.5f;
        public float attackRange = 1f;
        public float timeUntilNextAttack;
        public float attackSpeed = 0.25f;
        public float patrollingSpeed = 2f;
        private bool isDead;
        public float timeUntilCanBeDamaged;
        public Vector3 OriginalPosition { get; private set; }
        [SerializeField] private float heightOffset;
        [SerializeField] private float maxHeightDifference = 1.0f;
        [SerializeField] private bool useHeightDifference = true;
        

        private static readonly int MovementSpeed = Animator.StringToHash("movementSpeed");
        private static readonly int Attacking = Animator.StringToHash("attacking");
        private static readonly int Following = Animator.StringToHash("following");
        private static readonly int Hit = Animator.StringToHash("hit");
        private static readonly int Dead = Animator.StringToHash("dead");

        public LayerMask viewBlockerLayerMask;
        public LayerMask playerLayer;
        Collider[] hitColliders = new Collider[1];
        
        public DynamicStat health;
        public DynamicStat mana;

        private Collider enemyCollider;

        private void Awake()
        {
            agent = GetComponent<NavMeshAgent>();
            animator = GetComponent<Animator>();
            enemyCollider = GetComponent<Collider>();

            stats = new List<Stat>();
            
            foreach (var baseStat in definition.baseStats)
            {
                stats.Add(new Stat(baseStat.name, baseStat.BaseValue));
            }
            
            health = new DynamicStat(definition.health.name, definition.health.BaseValue);
            mana = new DynamicStat(definition.mana.name, definition.mana.BaseValue);
        }
        private void OnEnable()
        {
            SceneLinkedSMB<Enemy>.Initialise(animator, this);
            enemyCollider.enabled = true;
            health.CurrentValue = health.BaseValue;
            mana.CurrentValue = mana.BaseValue;
            isDead = false;
            OriginalPosition = transform.position;
        }

        private void OnDisable()
        {
            target = null;
            foreach (var stat in stats)
            {
                stat.RemoveAllModifiers();
            }
            health.RemoveAllModifiers();
            mana.RemoveAllModifiers();
        }

        private void FixedUpdate()
        {
            if (target)
            {
                animator.SetBool(Attacking, Physics.CheckSphere(transform.position, attackRange, playerLayer));
                animator.SetBool(Following, Physics.CheckSphere(transform.position, fieldOfVisionRadius, playerLayer));
            }
            else
            {
                int numColliders  = Physics.OverlapSphereNonAlloc(transform.position, fieldOfVisionRadius, hitColliders, playerLayer);

                for (int i = 0; i < numColliders; i++)
                {
                    Vector3 eyePos = transform.position + Vector3.up * heightOffset;
                    Vector3 toPlayer = Player.Instance.transform.position - eyePos;
                    Vector3 toPlayerTop = Player.Instance.transform.position + Vector3.up * 2f - eyePos;
                    
                    if (useHeightDifference && Mathf.Abs(toPlayer.y + heightOffset) > maxHeightDifference)
                    {
                        // if the target is too high or too low no need to try to reach it, just abandon pursuit
                        return;
                    }

                    Vector3 toPlayerFlat = toPlayer;
                    toPlayerFlat.y = 0;

                    if (toPlayerFlat.sqrMagnitude <= fieldOfVisionRadius * fieldOfVisionRadius)
                    {
                        if (Vector3.Dot(toPlayerFlat.normalized, transform.forward) >
                            Mathf.Cos(fieldOfVisionAngle * 0.5f * Mathf.Deg2Rad))
                        {
                            bool canSee = false;

                            canSee |= !Physics.Raycast(eyePos, toPlayer.normalized, fieldOfVisionRadius,
                                viewBlockerLayerMask, QueryTriggerInteraction.Ignore);

                            canSee |= !Physics.Raycast(eyePos, toPlayerTop.normalized, toPlayerTop.magnitude,
                                viewBlockerLayerMask, QueryTriggerInteraction.Ignore);
                    
                            if (canSee)
                            {
                                target = Player.Instance.transform;
                                animator.SetBool(Following, true);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void Update()
        {
            animator.SetFloat(MovementSpeed, agent.velocity.magnitude / agent.speed);
        }
        
        public void TakeDamage(Stats playerStats)
        {
            if (isDead) return;

            if (Time.time < timeUntilCanBeDamaged) return;
            
            if (!target)
            {
                target = playerStats.transform;
            }

            var damage = CalculateDamage(playerStats);
                
            health.CurrentValue -= damage;
            
            OnTakeDamage?.Invoke(damage);
            
            if (health.CurrentValue == 0)
            {
                enemyCollider.enabled = false;
                animator.SetTrigger(Dead);
                isDead = true;
            }
            else
            {
                animator.SetTrigger(Hit);
                timeUntilCanBeDamaged = Time.time + 1.5f;
            }
        }

        public void Die()
        {
            OnDied?.Invoke(this);
            EventManager.Instance.EnemyDied(this);
        }

        private int CalculateDamage(Stats playerStats)
        {
            var physicalDefense = stats.Find(stat => stat.name == StatType.PHYSICAL_DEFENSE);
            return playerStats[StatType.PHYSICAL_ATTACK].Value - physicalDefense.Value;
        }
        
#if UNITY_EDITOR

        public void OnDrawGizmos()
        {
            Color c = new Color(0, 0, 0.7f, 0.4f);

            UnityEditor.Handles.color = Color.blue;
            Vector3 rotatedForward = Quaternion.Euler(0, -fieldOfVisionAngle * 0.5f, 0) * transform.forward;
            UnityEditor.Handles.DrawSolidArc(transform.position, Vector3.up, rotatedForward, fieldOfVisionAngle, fieldOfVisionRadius);
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, attackRange);
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, patrolDistance);
        }

#endif
    }
}