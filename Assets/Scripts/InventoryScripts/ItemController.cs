using System;
using System.Security.Cryptography;
using UnityEngine;

namespace InventoryScripts
{
    public class ItemController : MonoBehaviour
    {
        public Item Item;

        public bool canBePicked = false;
        public void Start()
        {
            if (InventoryManager.Instance.DestroyedItems.Contains(Item))
            {
                Destroy(gameObject);
            }
        }

        public void Pickup()
        {
            if (canBePicked == true)
            {
                InventoryManager.Instance.AddItem(Item);
                Destroy(gameObject);
                InventoryManager.Instance.AddItemToInventoryBar(Item);
            }
        }

        public void OnMouseDown()
        {
            Pickup();
        }
    }
}