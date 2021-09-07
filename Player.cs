using UnityEngine;

namespace _Project.Scripts
{
    public class Player : Singleton<Player>, ISavable
    {
        public Inventory Inventory { get; private set; }
        public Equipment Equipment { get; private set; }
        public Stats Stats { get; private set; }
        public Skills Skills { get; private set; }

        private void Awake()
        {
            Inventory = GetComponent<Inventory>();
            Equipment = GetComponent<Equipment>();
            Stats = GetComponent<Stats>();
            Skills = GetComponent<Skills>();
        }

        public object SaveData()
        {
            return new PlayerData
            {
                position = transform.position,
                rotation = transform.rotation
            };
        }
        
        public void LoadData(object data)
        {
            PlayerData playerData = (PlayerData) data;
            transform.position = playerData.position;
            transform.rotation = playerData.rotation;
        }
    }
}