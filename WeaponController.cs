using System.Collections.Generic;
using UnityEngine;
using UnityEngine.GameFoundation;

namespace _Project.Scripts
{
    public abstract class WeaponController : MonoBehaviour, ISavable
    {
        [SerializeField] private Transform weaponsParent;
        [SerializeField] private List<GameObject> weapons;
        [SerializeField] private Equipment equipment;
        [SerializeField] private string equipmentType;
        private int currentId;

        private void OnEnable()
        {
            equipment.OnEquip += Equip;
            equipment.OnUnEquip += UnEquip;
        }

        private void OnDisable()
        {
            equipment.OnEquip -= Equip;
            equipment.OnUnEquip -= UnEquip;
        }

        private void Equip(InventoryItem inventoryItem)
        {
            if (inventoryItem.definition.GetStaticProperty("equipmentType").AsString() == equipmentType)
            {
                int id = weapons.FindIndex(go => go.name == inventoryItem.definition.displayName);
                EnableWeapon(id);
            }
        }
        
        private void UnEquip(InventoryItem inventoryItem)
        {
            if (inventoryItem.definition.GetStaticProperty("equipmentType").AsString() == equipmentType)
                DisableWeapon();
        }

        [ContextMenu("Setup")]
        public void Setup()
        {
            foreach (Transform child in weaponsParent)
            {
                weapons.Add(child.gameObject);
            }
        }
        
        public GameObject GetCurrent()
        {
            return currentId == -1 ? null : weapons[currentId];
        }
        
        private void EnableWeapon(int id)
        {
            if (id != -1)
            {
                weapons[id].SetActive(true);
                currentId = id;
            }
        }

        private void DisableWeapon()
        {
            if (currentId != -1)
            {
                weapons[currentId].SetActive(false);
                currentId = -1;
            }
        }
        
        public object SaveData()
        {
            return new WeaponData
            {
                currentWeaponId = currentId
            };
        }

        public void LoadData(object data)
        {
            WeaponData weaponData = (WeaponData) data;
            EnableWeapon(weaponData.currentWeaponId);
        }
    }
}