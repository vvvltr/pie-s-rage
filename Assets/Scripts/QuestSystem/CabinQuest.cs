using System;
using UnityEngine;

namespace QuestSystem
{
    public class CabinQuest : QuestController
    {
        public QuestManager questManager;
        public Quest previousQuest;

        
        public Camera _camera;
        
        private event Action action;
        private void Awake()
        {
            //thisQuest = new Quest(5, "Open door to engine quest", "Pick a scrap and open the locked door with it");
            //questManager.Quests.Add(Quest);
        }
        
        public void EndQuest()
        {
            thisQuest.isCompleted = true;
            questManager.CompleteQuest(thisQuest);
            
            action -= EndQuest;
        }

        public void Start()
        {            
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;

            previousQuest = questManager.Quests[3];
            thisQuest = questManager.Quests[4];

            action += EndQuest;
        }

        private void Update()
        {
            if (_camera.transform.GetComponent<EventController>().miniGamePassed)
            {
                action?.Invoke();
            }

        }
    }
}