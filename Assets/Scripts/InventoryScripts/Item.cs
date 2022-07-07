using UnityEngine;

namespace InventoryScripts
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Create new usable item")]
    public class Item : ScriptableObject
    {
        public int id;
        public string itemName;
        public Sprite itemIcon;
    }
}