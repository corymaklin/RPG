using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class RadialMenuElement : MonoBehaviour
    {
        [SerializeField] private string ui;

        private void Awake()
        {
            var button = GetComponent<Button>();
            button.onClick.AddListener(delegate { UIManager.Instance.Show(ui); });
        }
    }
}