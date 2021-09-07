using _Project.Scripts.Managers;
using UnityEngine;

namespace _Project.Scripts.UI
{
    public class EquipmentSlot : BaseSlot
    {
        public string equipmentType;
        
        private void Awake()
        {
            base.Awake();
            button.onClick.AddListener(delegate
            {
                if (inventoryItem != null)
                    equipment.UnEquip(inventoryItem);
            });
        }
    }
}