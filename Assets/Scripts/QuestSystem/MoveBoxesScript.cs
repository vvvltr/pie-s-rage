using UnityEngine;

namespace QuestSystem
{
    public class MoveBoxesScript : QuestController
    {
        public QuestManager questManager;

        public GameObject questObject;
        private void Awake()
        {
            //thisQuest = new Quest(5, "Open door to engine quest", "Pick a scrap and open the locked door with it");
            //questManager.Quests.Add(Quest);
        }
        
        public void EndQuest()
        {
            thisQuest.isActive = true;
            questManager.CompleteQuest(thisQuest);
            Destroy(questObject);
        }

        public void Start()
        {
            thisQuest = questManager.Quests[0];
        }
        

        public void OnMouseDown()
        {
            EndQuest();
            questManager.DisplayQuest();
        }
    }
}