using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
	public string[] tags; // массив тегов, объекты которых можно двигать
	public Camera _camera; // основная камера сцены
	public enum ProjectMode { Project3D = 0, Project2D = 1 };
	public ProjectMode mode = ProjectMode.Project3D;
	public float step = 5; // шаг для изменения высоты в 3D
	private Transform curObj;
	private float mass;
	public bool checkForCollision;

	private Vector3 offset;

	void Start()
	{
		checkForCollision = true;
		if (mode == ProjectMode.Project2D) _camera.orthographic = true;
	}

	bool GetTag(string curTag)
	{
		bool result = false;
		foreach (string t in tags)
		{
			if (t == curTag) result = true;
		}
        if (!result)
        {
			Debug.Log(curTag);
		}
		return result;
	}

	void Update()
	{
		if (Input.GetMouseButton(0) && checkForCollision) // Удерживать left кнопку мыши
		{
			Debug.Log("aaaa");
			if (mode == ProjectMode.Project3D)
			{
				Debug.Log("bbbb");
				RaycastHit hit;
				Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
				if (Physics.Raycast(ray, out hit))
				{
					Debug.Log("cccc");
					if (GetTag(hit.transform.tag) && hit.rigidbody && !curObj)
					{
						Debug.Log("dddd");
						curObj = hit.transform;
						mass = curObj.GetComponent<Rigidbody>().mass; // запоминаем массу объекта
						curObj.GetComponent<Rigidbody>().mass = 0.0001f; // убираем массу, чтобы не сбивать другие объекты
						curObj.GetComponent<Rigidbody>().useGravity = false; // убираем гравитацию
						curObj.GetComponent<Rigidbody>().freezeRotation = true; // заморозка вращения
																				//curObj.position += new Vector3(0, 0.5f, 0); // немного приподымаем выбранный объект
						offset = curObj.position -
						Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
					}
				}

				if (curObj)
				{
					Debug.Log("eeee");
					//Vector3 mousePosition = _camera.ScreenToWorldPoint(new Vector3(curObj.position.x, curObj.position.y, curObj.position.z));
					//curObj.GetComponent<Rigidbody>().MovePosition(new Vector3(mousePosition.x, curObj.position.y + Input.GetAxis("Mouse ScrollWheel") * step, mousePosition.z));
					Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
					curObj.GetComponent<Rigidbody>().MovePosition(Camera.main.ScreenToWorldPoint(newPosition) + offset);
				}
			}
			else
			{
				RaycastHit2D hit = Physics2D.Raycast(_camera.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
				if (hit.transform != null)
				{
					if (GetTag(hit.transform.tag) && hit.rigidbody && !curObj)
					{
						curObj = hit.transform;
						mass = curObj.GetComponent<Rigidbody2D>().mass;
						curObj.GetComponent<Rigidbody2D>().mass = 0.0001f;
						//curObj.GetComponent<Rigidbody2D>().gravityScale = 0;
						curObj.GetComponent<Rigidbody2D>().freezeRotation = true;
						//curObj.position += new Vector3(0, 0.5f, 0);
					}
				}

				if (curObj)
				{
					Vector3 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
					curObj.GetComponent<Rigidbody2D>().MovePosition(new Vector3(mousePosition.x, mousePosition.y, curObj.position.z));
				}
			}
		}
		else if (curObj)
		{
			Debug.Log("ffff");
			if (curObj.GetComponent<Rigidbody>())
			{
				Debug.Log("gggg");
				//curObj.GetComponent<Rigidbody>().freezeRotation = false;
				//curObj.GetComponent<Rigidbody>().useGravity = true;
				curObj.GetComponent<Rigidbody>().mass = mass;
				if (checkForCollision == false)
				{
					inCollision();
				}
			}
			else
			{
				curObj.GetComponent<Rigidbody2D>().freezeRotation = false;
				curObj.GetComponent<Rigidbody2D>().mass = mass;
				//curObj.GetComponent<Rigidbody2D>().gravityScale = 1;
			}
			curObj = null;
		}
	}
	public void inCollision()
    {
		checkForCollision = !checkForCollision;
    }
}

