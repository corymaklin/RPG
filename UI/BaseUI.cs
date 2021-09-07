using _Project.Scripts.Managers;
using UnityEngine;

namespace _Project.Scripts.UI
{
    public class BaseUI : MonoBehaviour
    {
        public bool isShowing => canvasGroup.alpha == 1;
        protected CanvasGroup canvasGroup;

        protected void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }

        public virtual void Show()
        {
            canvasGroup.alpha = 1;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.interactable = true;
        }

        public virtual void Hide()
        {
            canvasGroup.alpha = 0;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.interactable = false;
        }
    }
}