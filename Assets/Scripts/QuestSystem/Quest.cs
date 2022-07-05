using InventoryScripts;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;


namespace QuestSystem
{
    [System.Serializable]
    public class Quest
    {
        public bool isActive;
        
        public int questId;
        public string questTitle;
        public string questInfo;
        public Item questReward;

        public Quest(int id, string title, string info)
        {
            this.questId = id;
            this.questTitle = title;
            this.questInfo = info;
        }
    }
}