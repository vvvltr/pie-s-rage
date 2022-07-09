using System.Collections;
using System.Collections.Generic;
using QuestSystem;
using UnityEngine;
using UnityEngine.SceneManagement;



public class EventController : MonoBehaviour
{
    public QuestController questController;
    
    private List<Vector3> b_pos_1;
    private List<Vector3> b_pos_2;
    private bool clicked;
    private bool sp;
    private bool miniGameOn;
    public bool miniGamePassed;
    public GameObject room;
    public GameObject iskra;
    public GameObject moving_boxes_1;
    public GameObject moving_boxes_2;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        /*b_pos_1 = new List<Vector3>();
        b_pos_1.Add(new Vector3(-2.71f, 1.91f, 0.85f));
        b_pos_1.Add(new Vector3(-2.71f, 1.92f, 3.71f));
        b_pos_1.Add(new Vector3(-2.46f, 1.91f, 6.41f));
        b_pos_1.Add(new Vector3(-2.65f, 3.87f, 6.27f));
        b_pos_1.Add(new Vector3(-3.14f, 4.2f, 1.07f));
        b_pos_2 = new List<Vector3>(5);
        b_pos_2.Add(new Vector3(-3.19f, 1.91f, -6.54f)); //Vector3(-3.19000006,1.90999997,-6.53999996)
        b_pos_2.Add(new Vector3(-0.65f, 1.92f, -6.36f));
        b_pos_2.Add(new Vector3(-3.1f, 1.91f, -3.91f));
        b_pos_2.Add(new Vector3(-3.25f, 3.87f, -3.95f));
        b_pos_2.Add(new Vector3(-3.42f, 4.9f, -7.2f));*/
        set_boxes_1();
        clicked = false;
        miniGameOn = false;
        miniGamePassed = false;
        canvas.SetActive(false);
        room.SetActive(true);
        iskra.SetActive(true);
        sp = false;
    }  

    // Update is called once per frame
    void Update()
    {
        if (!clicked && ((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began)))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //GameObject target = hit.collider.GameObject;
                string n = hit.transform.name;
                string n3 = n[0] +""+ n[1] +""+ n[2];
                if (((sp==false)&&(hit.collider != null)) && (n3 == "Box" && !miniGamePassed))
                {
                    //room.SetActive(false);
                    canvas.SetActive(true);
                    //transform.Rotate(180, 0, 0);
                    clicked = true;
                }
            }
        }
        if (clicked)
        {
            miniGameOn = true;
            clicked = false;
        }
    }
    public void Cliked()
    {
        clicked = !clicked;
    }
    public void StopMiniGame()
    {
        set_boxes_2();
        miniGameOn = false;
        miniGamePassed = true;
        canvas.SetActive(false);
        iskra.SetActive(false);
        //room.SetActive(true);
    }
    public void StopMiniGame2()
    {
        set_boxes_2();
        miniGameOn = false;
        sp = true;
        //miniGamePassed = true;
        canvas.SetActive(false);
        //room.SetActive(true);
    }
    private void set_boxes_1()
    {
        moving_boxes_1.SetActive(true);
        moving_boxes_2.SetActive(false);

    }
    private void set_boxes_2()
    {
        moving_boxes_1.SetActive(false);
        moving_boxes_2.SetActive(true);
    }
}
