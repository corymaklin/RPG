using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts
{
    public class Gun : MonoBehaviour, IActivatable
    {
        [SerializeField] private Stats playerStats;
        [SerializeField] private ParticleSystem shootVfx;
        [SerializeField] private AudioSource shootSfx;
        [SerializeField] private Bullet bulletPrefab;
        [SerializeField] private Transform spawnPoint;
        [SerializeField] private float force = 10f;
        public float fireRate = 15f;
        private float nextTimeToFire;
        private Queue<Bullet> queue = new Queue<Bullet>();
        public void Activate()
        {
            if (Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / fireRate;
                
                if (shootSfx)
                    shootSfx.Play();
                if (shootVfx)
                    shootVfx.Play();

                var bullet = GetBullet();
                var rb = bullet.GetComponent<Rigidbody>();
                rb.AddRelativeForce(Vector3.forward * force, ForceMode.Impulse);
            }
        }

        private Bullet GetBullet()
        {
            Bullet bullet;

            if (queue.Count == 0)
            {
                bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
                bullet.playerStats = playerStats;
                bullet.OnHit += ReturnBullet;
                bullet.OnTimeIsUp += ReturnBullet;
            }
            else
            {
                bullet = queue.Dequeue();
                bullet.transform.position = spawnPoint.position;
                bullet.transform.rotation = spawnPoint.rotation;
                bullet.gameObject.SetActive(true);
            }

            return bullet;
        }

        private void ReturnBullet(Bullet bullet)
        {
            queue.Enqueue(bullet);
            bullet.gameObject.SetActive(false);
        }
    }
}