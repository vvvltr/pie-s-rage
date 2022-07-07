namespace QuestSystem
{
    [System.Serializable]
    public class Quest
    {
        public bool isActive;
        public bool isCompleted;
        
        public string questTitle;
        public string questInfo;
        

        public Quest(string title, string info)
        {
            this.questTitle = title;
            this.questInfo = info;
        }
    }
}