using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class BaseStatUI : MonoBehaviour
    {
        [SerializeField] protected Text value;
        public string statName;
        public StatsUI container;
        public virtual void Refresh(Stat stat)
        {
            value.text = stat.Value.ToString();
        }
    }
}