using _Project.Scripts.Enemies;
using UnityEngine;

namespace _Project.Scripts
{
    public class Sword : MonoBehaviour
    {
        [SerializeField] private Stats playerStats;
        private void OnTriggerEnter(Collider other)
        {
            var enemy = other.GetComponent<Enemy>();
            enemy.TakeDamage(playerStats);
        }
    }
}