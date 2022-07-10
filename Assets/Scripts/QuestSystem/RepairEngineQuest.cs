using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace QuestSystem
{
    public class RepairEngineQuest : QuestController
    {
        public QuestManager questManager;
        public Quest previousQuest;

        public GameObject particles;
        
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
            particles.SetActive(false);
            SceneManager.LoadScene("Win");
            
            action -= EndQuest;
        }

        public void Start()
        {            
            questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;

            previousQuest = questManager.Quests[4];
            thisQuest = questManager.Quests[5];

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