using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

namespace _Project.Scripts
{
    public class VRPlayer : Player
    {
        [SerializeField] private GameObject leftHandRayInteractor;
        [SerializeField] private GameObject rightHandRayInteractor;
        [SerializeField] private GameObject leftHandDirectInteractor;
        [SerializeField] private GameObject rightHandDirectInteractor;
        [SerializeField] private ActionBasedContinuousMoveProvider actionBasedContinuousMoveProvider;
        [SerializeField] private ActionBasedContinuousTurnProvider actionBasedContinuousTurnProvider;
        [SerializeField] private Transform rightHand;
        [SerializeField] private Transform leftHand;
        
        private void OnEnable()
        {
            UIManager.Instance.OnShowUI += EnableUIMode;
            UIManager.Instance.OnHideUI += DisableUIMode;
        }

        private void OnDisable()
        {
            UIManager.Instance.OnShowUI -= EnableUIMode;
            UIManager.Instance.OnHideUI -= DisableUIMode;
        }

        private void EnableUIMode()
        {
            actionBasedContinuousMoveProvider.enabled = false;
            actionBasedContinuousTurnProvider.enabled = false;
            leftHandDirectInteractor.SetActive(false);
            rightHandDirectInteractor.SetActive(false);
            leftHandRayInteractor.SetActive(true);
            rightHandRayInteractor.SetActive(true);
            leftHand.parent = leftHandRayInteractor.transform;
            rightHand.parent = rightHandRayInteractor.transform;
            leftHand.localPosition = Vector3.zero;
            leftHand.localRotation = Quaternion.Euler(-90, 180, -90);
            rightHand.localPosition = Vector3.zero;
            rightHand.localRotation = Quaternion.Euler(90, 0, 90);
        }

        private void DisableUIMode()
        {
            actionBasedContinuousMoveProvider.enabled = true;
            actionBasedContinuousTurnProvider.enabled = true;
            leftHandRayInteractor.SetActive(false);
            rightHandRayInteractor.SetActive(false);
            leftHandDirectInteractor.SetActive(true);
            rightHandDirectInteractor.SetActive(true);
            leftHand.parent = leftHandDirectInteractor.transform;
            rightHand.parent = rightHandDirectInteractor.transform;
            leftHand.localPosition = Vector3.zero;
            leftHand.localRotation = Quaternion.Euler(-90, 180, -90);
            rightHand.localPosition = Vector3.zero;
            rightHand.localRotation = Quaternion.Euler(90, 0, 90);
        }
    }
}