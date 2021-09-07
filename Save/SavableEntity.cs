using System;
using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts
{
    public class SavableEntity : MonoBehaviour
    {
        [SerializeField] private string id;
        public string Id => id;
        public object SaveData()
        {
            var state = new Dictionary<string, object>();
            
            foreach (var savable in GetComponents<ISavable>())
            {
                state[savable.GetType().ToString()] = savable.SaveData();
            }

            return state;
        }

        public void LoadData(object state)
        {
            var dict = state as Dictionary<string, object>;
            
            foreach (var savable in GetComponents<ISavable>())
            {
                if (dict.TryGetValue(savable.GetType().ToString(), out object value))
                {
                    savable.LoadData(value);
                }
            }
        }

        private void Reset()
        {
            id = Guid.NewGuid().ToString();
        }
    }
}