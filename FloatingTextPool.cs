using _Project.Scripts.Enemies;
using UnityEngine;

namespace _Project.Scripts
{
    public class FloatingTextPool : MonoBehaviour
    {
        [SerializeField] private Enemy enemy;
        [SerializeField] private GameObject experienceTextPrefab;
        [SerializeField] private GameObject damageTextPrefab;
        [SerializeField] private float initialHeight = 1f;

        private void OnEnable()
        {
            enemy.OnTakeDamage += ShowDamage;
            enemy.OnDied += ShowExperienceReward;
        }

        private void OnDisable()
        {
            enemy.OnTakeDamage -= ShowDamage;
            enemy.OnDied -= ShowExperienceReward;
        }

        private void ShowDamage(int damage)
        {
            var floatingText = Instantiate(damageTextPrefab, transform.position, transform.rotation, transform);

            floatingText.transform.localPosition = new Vector3(0, initialHeight, 0);

            floatingText.GetComponent<TextMesh>().text = $"{damage}";
        }

        private void ShowExperienceReward(Enemy enemy)
        {
            var floatingText = Instantiate(damageTextPrefab, transform.position, transform.rotation);

            floatingText.GetComponent<TextMesh>().text = $"{enemy.definition.experienceReward}";
        }
    }
}