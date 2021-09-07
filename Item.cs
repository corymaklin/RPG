using UnityEngine;

namespace _Project.Scripts
{
    public class Item : MonoBehaviour
    {
        [SerializeField] private string definitionKey;
        public string DefinitionKey => definitionKey;
    }
}