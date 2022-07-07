using System.Collections;
using System.Collections.Generic;
using QuestSystem;
using UnityEngine;
using UnityEngine.UI;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
        Quests.Add(new Quest(1, "Boxes quest", "Move boxes to get access to other items"));
        Quests.Add(new Quest(2, "Repair reactor quest", "Rotate pieces of picture to solve it"));
        Quests.Add(new Quest(3, "Code panel quest", "Enter right password to get access to the cabin room"));
        Quests.Add(new Quest(4, "Cabin panel quest", "Rotate pieces of picture to solve it"));
        Quests.Add(new Quest(5, "Open door to engine quest", "Pick a scrap and open the locked door with it"));
        Quests.Add(new Quest(6, "Repair engine quest", "Rotate pieces of wires to connect them and make the engine start"));
        
    }
    
    public List<Quest> Quests = new List<Quest>();
    public List<Quest> CompletedQuests = new List<Quest>();
    
    public Quest CurrentQuest;

    public QuestDisplayed QuestDisplayed;
    
    //public GameObject QuestObject;
    //public Transform QuestContent;

    // Start is called before the first frame update
    void Start()
    {
        /*Quest BoxesQuest = 
            new Quest(1, "Boxes quest", "Move boxes to get access to other items");
        Quest RepairReactorQuest = 
            new Quest(2, "Repair reactor quest", "Rotate pieces of picture to solve it");
        Quest CodePanelQuest = 
            new Quest(3, "Code panel quest", "Enter right password to get access to the cabin room");
        //Quest CabinPanedQuest = new Quest(4, "Cabin panel quest", "Rotate pieces of picture to solve it");
        Quest OpenEngineQuest = new Quest(
            5,
            "Open door to engine quest", 
            "Pick a scrap and open the locked door with it");
        Quest RepairEngine = new Quest(
            6, 
            "Repair engine quest", 
            "Rotate pieces of wires to connect them and make the engine start");*/
        //Quests.Add(BoxesQuest);
        //Quests.Add(RepairReactorQuest);
        //Quests.Add(CodePanelQuest);
        
        //Quests.Add(OpenEngineQuest);
        //Quests.Add(RepairEngine);
        //Quests.Add(CabinPanedQuest);

        if (Quests.Count > 0)
        {
            CurrentQuest = Quests[0];
        }
        DisplayQuest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CompleteQuest(Quest completedQuest)
    {
        completedQuest.isCompleted = true;
        CompletedQuests.Add(completedQuest);
        Quests.Remove(completedQuest);
        if (Quests.Count > 0)
        {
            CurrentQuest = Quests[0];
            DisplayQuest();
        }
    }
    
    /*public void DisplayQuest()
    {
        questDisplayed = Instantiate(QuestObject, QuestContent);
        questDisplayed.transform.Find("Title").GetComponent<Text>().text = CurrentQuest.questTitle;
        questDisplayed.transform.Find("Description").GetComponent<Text>().text = CurrentQuest.questInfo;
    }*/

    public void DisplayQuest()
    {
        ClearDisplay();
        QuestDisplayed.transform.Find("Title").GetComponent<Text>().text = CurrentQuest.questTitle;
        QuestDisplayed.transform.Find("Description").GetComponent<Text>().text = CurrentQuest.questInfo;
    }

    public void ClearDisplay()
    {
        QuestDisplayed.transform.Find("Title").GetComponent<Text>().text = null;
        QuestDisplayed.transform.Find("Description").GetComponent<Text>().text = null;
    }
}
