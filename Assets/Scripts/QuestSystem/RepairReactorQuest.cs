using System;
using InventoryScripts;
using UnityEngine;

namespace QuestSystem
{
    public class RepairReactorQuest : QuestController
    {
        public QuestManager questManager;
        public Quest previousQuest;

        public GameObject Sudoku;
        
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
            Debug.Log("removed");
            questManager.Quests.Remove(thisQuest);

            Sudoku.SetActive(true);
            
            action -= EndQuest;
        }

        public void Start()
        {
            previousQuest = questManager.Quests[1];
            thisQuest = questManager.Quests[2];
            
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
            
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