using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCheker : MonoBehaviour
{
    public Camera _camera;
    public Transform target;
    void Update()
    {
        if (!Physics.Linecast(transform.position, target.position))
        {
            StartCoroutine(ExampleCoroutine());
        }
    }
    IEnumerator ExampleCoroutine()
    {

        //yield on a new YieldInstruction that waits for 3 seconds.
        yield return new WaitForSeconds(3);

        _camera.transform.GetComponent<EventController>().StopMiniGame();
    }
}
