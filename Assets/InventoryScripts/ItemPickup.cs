using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    // Start is called before the first frame update
    public Item Item;

    public void PickUp()
    {
        InventoryManager.Instance.AddItem(Item);
        Destroy(gameObject);
    }

    public void OnMouseDown()
    {
        PickUp();
    }
}
