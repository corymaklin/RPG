using System;
using System.Collections.Generic;
using _Project.Scripts.UI;
using UnityEngine;

namespace _Project.Scripts.Managers
{
    public class UIManager : Singleton<UIManager>
    {
        private BaseUI activeUI;
        
        private Dictionary<string, BaseUI> uis;
        public event Action OnShowUI;
        public event Action OnHideUI;

        [SerializeField] private InventoryUI inventoryUI;
        [SerializeField] private EquipmentUI equipmentUI;
        [SerializeField] private StatsUI statsUI;
        [SerializeField] private CharacterSelectionUI characterSelectionUI;
        [SerializeField] private MenuUI menuUI;
        [SerializeField] private RadialMenu radialMenu;
        

        private void Start()
        {
            uis = new Dictionary<string, BaseUI>
            {
                { Constants.UI.EQUIPMENT, equipmentUI },
                { Constants.UI.INVENTORY, inventoryUI },
                { Constants.UI.STATS, statsUI },
                { Constants.UI.MENU, menuUI },
                { Constants.UI.CHARACTER_SELECTION, characterSelectionUI },
                { Constants.UI.RADIAL_MENU, radialMenu }
            };
        }

        public void Show(string ui)
        {
            if (activeUI)
            {
                activeUI.Hide();                
            }
            
            uis[ui].Show();
            activeUI = uis[ui];
            
            OnShowUI?.Invoke();
        }
        public void Hide()
        {
            if (activeUI != null)
            {
                activeUI.Hide();
                activeUI = null;
                OnHideUI?.Invoke();   
            }
        }
    }
}