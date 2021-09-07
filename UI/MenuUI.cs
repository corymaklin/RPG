using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class MenuUI : BaseUI
    {
        [SerializeField] private Button saveButton;
        [SerializeField] private Button closeButton;
        [SerializeField] private Button loadButton;
        [SerializeField] private Button exitButton;
        [SerializeField] private Button optionsButton;
        
        private void Awake()
        {
            base.Awake();
            closeButton.onClick.AddListener(delegate { UIManager.Instance.Hide(); });
            saveButton.onClick.AddListener(delegate { SaveManager.Instance.Save(); });
         
        }
    }
}