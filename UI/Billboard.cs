using UnityEngine;

namespace _Project.Scripts.UI
{
    public class Billboard : MonoBehaviour
    {
        private Transform mainCamera;
        private void Start()
        {
            mainCamera = Camera.main.transform;
        }
        
        private void LateUpdate()
        {
            transform.LookAt(mainCamera.transform);
        }
    }
}