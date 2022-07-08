using System.Collections;
using System.Collections.Generic;
using QuestSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Doors : MonoBehaviour
{
    public QuestManager questManager;

    public MoveBoxesQuest MoveBoxesQuest;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
                    if (n == "DoorToReactor" && questManager.CompletedQuests.Count>1)
                        SceneManager.LoadScene("Reactor");
                    else if (n == "DoorToCabin" && questManager.CompletedQuests.Count>2)
                        SceneManager.LoadScene("Cabin");
                    else if (n == "DoorToEngine" && questManager.CompletedQuests.Count>4)
                        SceneManager.LoadScene("Engine");
                    else if (n == "DoorToHallway")
                        SceneManager.LoadScene("Hallway");
                }
                
            }
        }


    }
}

