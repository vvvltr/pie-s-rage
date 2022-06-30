using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public void Awake()
    {
        Instance = this;
    }

    public void AddItem(Item addedItem)
    {
        Items.Add(addedItem);
    }

    public void RemoveItem(Item removedItem)
    {
        Items.Remove(removedItem);
    }
}
