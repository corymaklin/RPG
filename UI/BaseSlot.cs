using UnityEngine;
using UnityEngine.GameFoundation;
using UnityEngine.UI;

namespace _Project.Scripts.UI
{
    public class BaseSlot : MonoBehaviour
    {
        public InventoryItem inventoryItem;
        protected Image image;
        protected Button button;
        public Equipment equipment;

        protected void Awake()
        {
            Transform icon = transform.Find("Icon");
            image = icon.GetComponent<Image>();
            button = GetComponent<Button>();
        }

        public void Set(InventoryItem inventoryItem)
        {
            this.inventoryItem = inventoryItem;
            image.sprite = inventoryItem.definition.GetStaticProperty("sprite").AsAsset<Sprite>();
            image.enabled = true;
        }

        public void UnSet()
        {
            inventoryItem = null;
            image.sprite = null;
            image.enabled = false;
        }
    }
}