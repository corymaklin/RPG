using System;
using _Project.Scripts.Enemies;
using UnityEngine;
using UnityEngine.GameFoundation;

namespace _Project.Scripts.Managers
{
    public class EventManager : Singleton<EventManager>
    {
        public event Action<Enemy> OnEnemyDied;
        public void EnemyDied(Enemy enemy) => OnEnemyDied?.Invoke(enemy);
    }
}