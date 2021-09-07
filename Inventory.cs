using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.GameFoundation;

namespace _Project.Scripts
{
    public class Inventory : MonoBehaviour, ISavable
    {
        private string id;
        public ItemList Items => items;
        private ItemList items;
        public event Action<InventoryItem> OnItemAddedToInventory;
        public event Action<InventoryItem> OnItemRemovedFromInventory;
        public event Action OnInventoryInitialized;

        private Equipment equipment;

        private void Awake()
        {
            equipment = GetComponent<Equipment>();
        }

        private void OnEnable()
        {
            GameFoundationSdk.initialized += Initialize;
            equipment.OnEquip += Remove;
            equipment.OnUnEquip += Add;
        }

        private void OnDisable()
        {
            GameFoundationSdk.initialized -= Initialize;
            equipment.OnEquip -= Remove;
            equipment.OnUnEquip -= Add;
        }

        public void Initialize()
        {
            items = !String.IsNullOrEmpty(id) ? GameFoundationSdk.inventory.FindCollection<ItemList>(id) : GameFoundationSdk.inventory.CreateList();
            ICollection<IItemCollection> collection = new List<IItemCollection>();
            GameFoundationSdk.inventory.GetCollections(collection);
            OnInventoryInitialized?.Invoke();
        }

        public void Add(Item item)
        {
            InventoryItemDefinition itemDefinition = GameFoundationSdk.catalog.Find<InventoryItemDefinition>(item.DefinitionKey);
            InventoryItem inventoryItem = GameFoundationSdk.inventory.CreateItem(itemDefinition);
            Add(inventoryItem);
            Destroy(item.gameObject);
        }

        private void Add(InventoryItem inventoryItem)
        {
            items.Add(inventoryItem);
            OnItemAddedToInventory?.Invoke(inventoryItem);
        }

        private void Remove(InventoryItem inventoryItem)
        {
            OnItemRemovedFromInventory?.Invoke(inventoryItem);
            items.Remove(inventoryItem);
        }
        
        public object SaveData()
        { 
            return new InventoryData
            {
                id = items.id
            };
        }
        
        public void LoadData(object data)
        {
            InventoryData inventoryData = (InventoryData) data;
            id = inventoryData.id;
        }
    }
}