using UnityEngine;
using System.Collections;

public class switch1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{

	}

	void OnMouseDown()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log("Click");
			Main.pressedb1 = true;
		}
	}
}
