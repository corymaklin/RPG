using System.Collections;
using _Project.Scripts.UI;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.Enemies
{
    public class EnemyHealthBar : BaseUI
    {
        
        [SerializeField] private Enemy enemy;
        [SerializeField] private float delay = 10f;
        private Slider slider;
        private Coroutine coroutine;
        
        protected void Awake()
        {
            base.Awake();
            slider = GetComponent<Slider>();
        }

        private void Start()
        {
            slider.maxValue = enemy.health.Value;
            enemy.OnTakeDamage += Refresh;
        }

        private void OnDestroy()
        {
            enemy.OnTakeDamage -= Refresh;
        }
        private void Refresh(int damage)
        {
            if (enemy.health.CurrentValue == 0)
            {
                Hide();
            }
            else
            {
                if (canvasGroup.alpha == 0)
                {
                    Show();    
                }
                else
                {
                    StopCoroutine(coroutine);
                }

                coroutine = StartCoroutine(Wait());
                slider.value = enemy.health.CurrentValue;
            }
        }

        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(delay);
            Hide();
        }
    }
}