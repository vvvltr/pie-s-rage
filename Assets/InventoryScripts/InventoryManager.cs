using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.VFX;

namespace InventoryScripts
{
    public class InventoryManager : MonoBehaviour
    {
        public static InventoryManager Instance;
        public List<Item> Items = new List<Item>();

        public List<Item> DestroyedItems = new List<Item>();

        public GameObject ItemObject;
        public Transform ItemContent;
        
        public void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
            DestroyedItems.Add(item);
        }

        /*public void ListItems()
        {
            for (int i = 0; i < Instance.Items.Count; i++)
            {
                GameObject gameObject = Instantiate(ItemObject, ItemContent);
                
                var itemName = gameObject.transform.Find("itemName").GetComponentInChildren<Text>();
                var itemIcon = gameObject.transform.Find("itemIcon").GetComponent<Image>();
                
                itemName.text = Instance.Items[i].itemName;
                itemIcon.sprite = Instance.Items[i].itemIcon;
            }
        }*/

        public void AddItemToInventoryBar(Item item)
        {
            GameObject newInventoryElement = Instantiate(ItemObject, ItemContent);

            newInventoryElement.transform.Find("name").GetComponent<Text>().text = item.itemName;
            newInventoryElement.transform.Find("icon").GetComponent<Image>().sprite = item.itemIcon;
        }
    }
}