using System;
using System.Collections.Generic;
using InventoryScripts;
using UnityEngine;

namespace QuestSystem
{
    public class PickScrapQuest : QuestController
    {
        public QuestManager questManager;
        public Quest previousQuest;
        public ItemController Scrap;
        public Item ScrapItem;
        public InventoryManager InventoryManager;
        
        private event Action action;
        private void Awake()
        {
            //thisQuest = new Quest(5, "Open door to engine quest", "Pick a scrap and open the locked door with it");
            //questManager.Quests.Add(Quest);
        }
        
        public void EndQuest()
        {
            questManager.CompleteQuest(thisQuest);

            action -= EndQuest;
        }

        public void Start()
        {
            previousQuest = questManager.Quests[0];
            thisQuest = questManager.Quests[1];
            
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
            InventoryManager = GameObject.Find("InventoryManager").GetComponent("InventoryManager") as InventoryManager;
            action += EndQuest;
        }

        private void Update()
        {
            if (previousQuest.isCompleted)
            {
                Scrap.canBePicked = true;
                if (InventoryManager.DestroyedItems.Contains(ScrapItem))
                {
                    action?.Invoke();
                }
            }
        }
    }
}