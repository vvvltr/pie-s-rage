using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveObj : MonoBehaviour
{
    public GameObject show;
    public QuestManager questManager;
    // Start is called before the first frame update
    void Start()
    {
        questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
    }

    // Update is called once per frame
    void Update()
    {
            //Debug.Log(questManager.CompletedQuests.Count+"");
        if(questManager.CompletedQuests.Count >= 3)
        {
            show.SetActive(true);
        }
    }
}
