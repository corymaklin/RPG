using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.GameFoundation;

namespace _Project.Scripts.UI
{
    public class EquipmentUI : BaseUI
    {
        [SerializeField] private Transform slotParent;
        [SerializeField] private Equipment equipment;
        private Dictionary<string, EquipmentSlot> slots = new Dictionary<string, EquipmentSlot>();

        private void Awake()
        {
            base.Awake();
            foreach (var child in slotParent.GetComponentsInChildren<EquipmentSlot>(true))
            {
                child.equipment = equipment;
                slots[child.equipmentType] = child;
            }
        }

        private void OnEnable()
        {
            equipment.OnEquipmentInitialized += Initialize;
            equipment.OnEquip += Equip;
            equipment.OnUnEquip += UnEquip;
        }

        private void OnDisable()
        {
            equipment.OnEquip -= Equip;
            equipment.OnUnEquip -= UnEquip;
            equipment.OnEquipmentInitialized -= Initialize;
        }

        private void Equip(InventoryItem inventoryItem)
        {
            slots[inventoryItem.definition.GetStaticProperty("equipmentType").AsString()].Set(inventoryItem);
        }

        private void UnEquip(InventoryItem inventoryItem)
        {
            slots[inventoryItem.definition.GetStaticProperty("equipmentType").AsString()].UnSet();
        }

        private void Initialize()
        {
            foreach (InventoryItem inventoryItem in equipment.Items)
            {
                slots[inventoryItem.definition.GetStaticProperty("equipmentType").AsString()].Set(inventoryItem);
            }
        }
    }
}