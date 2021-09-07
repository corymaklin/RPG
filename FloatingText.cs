using DG.Tweening;
using UnityEngine;

namespace _Project.Scripts
{
    public class FloatingText : MonoBehaviour
    {
        public float time = 3f;
        private Transform mainCamera;

        private void Awake()
        {
            mainCamera = Camera.main.transform;
        }

        private void LateUpdate()
        {
            transform.LookAt(transform.position + mainCamera.forward);
        }

        private void Start()
        {
            transform.DOMove(transform.position + Vector3.up, time).OnKill(() => Destroy(gameObject));
        }
    }
}