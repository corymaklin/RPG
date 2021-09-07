using System.Collections.Generic;
using System.Linq;
using _Project.Scripts.Managers;
using UnityEngine;
using UnityEngine.GameFoundation;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class InventoryUI : BaseUI
    {
        [SerializeField] private Inventory inventory;
        [SerializeField] private Equipment equipment;
        [SerializeField] private Transform slotParent;
        [SerializeField] private Button closeButton;
        private List<InventorySlot> slots;

        private void Awake()
        {
            base.Awake();
            slots = slotParent.GetComponentsInChildren<InventorySlot>(true).ToList();
            foreach (var slot in slots)
            {
                slot.equipment = equipment;
            }
            closeButton.onClick.AddListener(delegate { UIManager.Instance.Hide(); });
        }

        private void OnEnable()
        {
            inventory.OnItemAddedToInventory += AddItemToInventory;
            inventory.OnItemRemovedFromInventory += RemoveItemFromInventory;
            inventory.OnInventoryInitialized += Initialize;
        }

        private void OnDisable()
        {
            inventory.OnItemAddedToInventory -= AddItemToInventory;
            inventory.OnItemRemovedFromInventory -= RemoveItemFromInventory;
            inventory.OnInventoryInitialized -= Initialize;
        }

        private void Initialize()
        {
            for (int i = 0; i < inventory.Items.Count; i++)
            {
                InventoryItem inventoryItem = inventory.Items[i];
                slots[i].Set(inventoryItem);
            }
        }
        
        private void AddItemToInventory(InventoryItem inventoryItem)
        {
            foreach (var slot in slots)
            {
                if (slot.inventoryItem == null)
                {
                    slot.Set(inventoryItem);
                    break;
                }
            }
        }

        private void RemoveItemFromInventory(InventoryItem inventoryItem)
        {
            foreach (var slot in slots)
            {
                if (slot.inventoryItem != null)
                {
                    if (slot.inventoryItem.id == inventoryItem.id)
                    {
                        slot.UnSet();
                    }
                }
            }
        }
    }
}