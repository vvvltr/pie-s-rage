using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject ItemObject;
    
    public void Awake()
    {
        Instance = this;
    }

    public void AddItem(Item addedItem)
    {
        Items.Add(addedItem);
    }

    public void ListItems()
    {
        foreach (var vItem in Items)
        {
            GameObject gameObject = Instantiate(ItemObject, ItemContent);
            var itemName = gameObject.transform.Find("name").GetComponent<Text>();
            var itemIcon = gameObject.transform.Find("icon").GetComponent<Image>();

            itemName.text = vItem.name;
            itemIcon.sprite = vItem.icon;
        }
    }
}
