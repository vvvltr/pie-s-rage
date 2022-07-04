using System;
using System.Security.Cryptography;
using UnityEngine;

namespace InventoryScripts
{
    public class ItemController : MonoBehaviour
    {
        public Item Item;

        public void Start()
        {
            if (InventoryManager.Instance.DestroyedItems.Contains(Item))
            {
                Destroy(gameObject);
            }
        }

        public void Pickup()
        {
            InventoryManager.Instance.AddItem(Item);
            Destroy(gameObject);
            InventoryManager.Instance.AddItemToInventoryBar(Item);
        }

        public void OnMouseDown()
        {
            Pickup();
        }
    }
}