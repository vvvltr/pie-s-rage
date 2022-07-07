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
            /*if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }*/
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
            thisQuest = questManager.Quests[0];
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