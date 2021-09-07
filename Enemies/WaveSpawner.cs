using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.Enemies
{
    public class WaveSpawner : MonoBehaviour
    {
        private Queue<Enemy> queue = new Queue<Enemy>();
        [SerializeField] private Transform[] spawnPoints;
        [SerializeField] private Enemy enemyPrefab;
        [SerializeField] private int size;
        [SerializeField] private float delay = 30f;

        private void Awake()
        {
            for (int i = 0; i < size; i++)
            {
                var enemy = Instantiate(enemyPrefab);
                enemy.gameObject.SetActive(false);
                queue.Enqueue(enemy);
            }
        }

        private void OnEnable()
        {
            foreach (var enemy in queue)
            {
                enemy.OnDied += Return;
            }
        }

        private void OnDisable()
        {
            foreach (var enemy in queue)
            {
                enemy.OnDied -= Return;
            }
        }

        private void Start()
        {
            StartCoroutine(Spawn());
        }
        
        private void Return(Enemy enemy)
        {
            enemy.gameObject.SetActive(false);
            queue.Enqueue(enemy);
        }
        
        private IEnumerator Spawn()
        {
            while (true)
            {
                while (queue.Count != 0)
                {
                    Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                    Enemy enemy = queue.Dequeue();
                    enemy.transform.position = spawnPoint.position;
                    enemy.gameObject.SetActive(true);
                }
                
                yield return new WaitForSeconds(delay);   
            }
        }
    }
}