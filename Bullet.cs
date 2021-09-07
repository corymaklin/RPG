using System;
using System.Collections;
using _Project.Scripts.Enemies;
using UnityEngine;

namespace _Project.Scripts
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private ParticleSystem impactVfx;
        [SerializeField] private AudioSource impactSfx;
        [SerializeField] private float delay = 3f;
        [NonSerialized] public Stats playerStats;
        public event Action<Bullet> OnHit;
        public event Action<Bullet> OnTimeIsUp;
        private IEnumerator coroutine;
        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            coroutine = WaitForCollision(delay);
            StartCoroutine(coroutine);
        }

        private void OnDisable()
        {
            rb.velocity = Vector3.zero;
        }

        private void OnCollisionEnter(Collision other)
        {
            StopCoroutine(coroutine);
            var enemy = other.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(playerStats);

            if (impactVfx)
            {
                if (impactSfx)
                    impactSfx.Play();
                
                impactVfx.Play();
                StartCoroutine(WaitForVfx(impactVfx.duration + impactVfx.startLifetime));
            }
            else
            {
                OnHit?.Invoke(this);
            }
        }

        private IEnumerator WaitForVfx(float delay)
        {
            yield return new WaitForSeconds(delay);
            OnHit?.Invoke(this);
        }
        
        private IEnumerator WaitForCollision(float delay)
        {
            yield return new WaitForSeconds(delay);
            OnTimeIsUp?.Invoke(this);
        }
    }
}