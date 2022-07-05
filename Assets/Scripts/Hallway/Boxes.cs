using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Boxes : MonoBehaviour
{
    private bool clicked;
    private bool miniGameOn;
    public GameObject room;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        clicked = false;
        miniGameOn = false;
        canvas.SetActive(false);
        room.SetActive(true);

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
                if (hit.collider != null && n3 == "Box")
                {
                    room.SetActive(false);
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
    void Cliked()
    {
        clicked = !clicked;
    }
    void StopMiniGame()
    {
        miniGameOn = false;
        canvas.SetActive(false);
        room.SetActive(true);
    }
}
