using _Project.Scripts.Managers;

namespace _Project.Scripts.UI
{
    public class InventorySlot : BaseSlot
    {
        private void Awake()
        {
            base.Awake();
            button.onClick.AddListener(delegate
            {
                if (inventoryItem != null)
                    equipment.Equip(inventoryItem);
            });
        }
    }
}