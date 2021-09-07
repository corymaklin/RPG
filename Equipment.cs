using System;
using System.Collections.Generic;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.GameFoundation;

namespace _Project.Scripts
{
    public class Equipment : MonoBehaviour, ISavable
    {
        private ItemMap items;
        public ItemMap Items => items;
        private string id;
        public event Action OnEquipmentInitialized;
        public event Action<InventoryItem> OnUnEquip;
        public event Action<InventoryItem> OnEquip;

        private void OnEnable()
        {
            GameFoundationSdk.initialized += Initialize;
        }

        private void OnDisable()
        {
            GameFoundationSdk.initialized -= Initialize;
        }
        
        public void Initialize()
        {
            items = !String.IsNullOrEmpty(id) ? GameFoundationSdk.inventory.FindCollection<ItemMap>(id) : GameFoundationSdk.inventory.CreateMap();
            OnEquipmentInitialized?.Invoke();
        }
        
        public void Equip(InventoryItem inventoryItem)
        {
            string equipmentType = inventoryItem.definition.GetStaticProperty("equipmentType").AsString();
            
            if (items.IsSlotSet(equipmentType))
                UnEquip(items.Get(equipmentType));
            
            items.Set(equipmentType, inventoryItem);
            OnEquip?.Invoke(inventoryItem);
        }

        public void UnEquip(InventoryItem inventoryItem)
        {
            items.Remove(inventoryItem);
            OnUnEquip?.Invoke(inventoryItem);
        }

        public object SaveData()
        {
            return new EquipmentData
            {
                id = items.id
            };
        }
        
        public void LoadData(object data)
        {
            EquipmentData equipmentData = (EquipmentData) data;
            id = equipmentData.id;
        }
    }
}