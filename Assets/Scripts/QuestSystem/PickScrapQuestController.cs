using System;
using UnityEngine;

namespace QuestSystem
{
    public class PickScrapQuestController : QuestController
    {
        public QuestManager questManager = QuestManager.Instance;

        public GameObject QuestObject;
        
        private void Awake()
        {
            foreach (var VARIABLE in questManager.Quests)
            {
                if (VARIABLE.questTitle == "Open door to engine quest")
                {
                    thisQuest = VARIABLE;
                }
            }
            //Quest = new Quest(5, "Open door to engine quest", "Pick a scrap and open the locked door with it");
            //questManager.Quests.Add(Quest);
        }
        
        public void EndQuest()
        { 
            questManager.CompleteQuest(thisQuest);
            Destroy(gameObject);
        }

        public void Start()
        {
            questManager.CurrentQuest = thisQuest;
            questManager.DisplayQuest();
        }
        

        public void OnMouseDown()
        {
            EndQuest();
            questManager.DisplayQuest();
        }
    }
}