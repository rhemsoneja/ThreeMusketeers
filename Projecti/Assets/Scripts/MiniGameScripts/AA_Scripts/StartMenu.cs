// Alphabets Game Test : UnityCoder.com
using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public int level = 1;
	
	
	// Update is called once per frame
	void OnMouseDown  () {
		Application.LoadLevel(level);
	}
	
	void OnMouseEnter () {
		GetComponent<GUITexture>().color = Color.green;
	}
	
	void OnMouseExit () {
		GetComponent<GUITexture>().color = Color.white;
	}
	
}
