using System;
using UnityEngine;

namespace QuestSystem
{
    public class CodePanelQuest : QuestController
    {
        public QuestManager questManager;

        public EnterButtonController enterButtonEvents;
        
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
        }

        private void Update()
        {
            
        }
    }
}