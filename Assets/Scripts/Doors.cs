using System.Collections;
using System.Collections.Generic;
using InventoryScripts;
using QuestSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public QuestManager questManager;

    public InventoryManager InventoryManager;
    // Start is called before the first frame update
    void Start()
    {
        InventoryManager = GameObject.Find("InventoryManager").GetComponent("InventoryManager") as InventoryManager;
    }

    // Update is called once per frame
    void Update()
    {
        questManager = GameObject.Find("QuestManager").GetComponent("QuestManager") as QuestManager;
        if (((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began)))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //GameObject target = hit.collider.GameObject;
                string n = hit.transform.name;
                
                string n4 = n[0] + "" + n[1] + "" + n[2];
                if (hit.collider != null && n4 == "Doo")
                {
                    if (n == "DoorToReactor" && questManager.Quests[1].isCompleted)
                        SceneManager.LoadScene("Reactor");
                    else if (n == "DoorToCabin" && questManager.Quests[3].isCompleted)
                        SceneManager.LoadScene("Cabin");
                    else if (n == "DoorToEngine" && questManager.Quests[4].isCompleted && InventoryManager.DestroyedItems.Count > 0)
                        SceneManager.LoadScene("Engine");
                    else if (n == "DoorToHallway")
                        SceneManager.LoadScene("Hallway");
                }
                
            }
        }


    }
}

