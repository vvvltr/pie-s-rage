using System;
using UnityEngine;

namespace QuestSystem
{
    public class MoveBoxesQuest : QuestController
    {
        //public MoveBoxesQuest Instance;

        public QuestManager questManager;
        public Camera _camera;

        private event Action action;
        
        private void Awake()
        {
            thisQuest.isCompleted = false;
            action += EndQuest;
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
            thisQuest = questManager.Quests[0];
            if (questManager.CompletedQuests.Count > 0)
            {
                _camera.transform.GetComponent<EventController>().StopMiniGame();
            }
        }

        private void Update()
        {
            if (_camera.transform.GetComponent<EventController>().miniGamePassed)
            {
                action?.Invoke();
                _camera.transform.GetComponent<EventController>().moving_boxes_2.SetActive(true);
            }
        }
        
    }
}