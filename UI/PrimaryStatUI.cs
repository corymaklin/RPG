using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class PrimaryStatUI : BaseStatUI
    {
        [SerializeField] private Button button;

        private void Awake()
        {
            button.onClick.AddListener(delegate { container.stats.SpendPoints(statName, 1); });
        }
    }
}