using UnityEngine;
using System.Collections;

public class switch3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Debug.Log("Click");
			CTOS_Main.pressedb3 = true;
		}
	}
}
