using System;
using UnityEngine;

namespace QuestSystem
{
    public class QuestController : MonoBehaviour
    {
        public Quest thisQuest;
        /*
        public void EndQuest()
        {
            QuestManager.Instance.CompletedQuests.Add(QuestManager.Instance.CurrentQuest);
            QuestManager.Instance.Quests.Remove(QuestManager.Instance.CurrentQuest);
        }

        public void Start()
        {
            QuestManager.Instance.Quests.Add(Quest);
            QuestManager.Instance.CurrentQuest = Quest;
            QuestManager.Instance.DisplayQuest();
        }

        public void OnMouseDown()
        {
            EndQuest();
            QuestManager.Instance.DisplayQuest();
        }
        
        */
    }
}