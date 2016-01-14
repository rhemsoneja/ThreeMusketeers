// Alphabets Game Test : UnityCoder.com
using UnityEngine;
using System.Collections;

public class showendscore : MonoBehaviour {

	private string playerName = "Nobody";
	private bool submit = false;
	
	// Use this for initialization
	void Start () {
		
		//Debug.Log(gameplay.score);
		GetComponent<GUIText>().text = "Score: " + AA_gameplay.score;
		


		
	}
	
	void OnGUI () 
	{

		if (!submit)
		{

			// Make a text field that modifies stringToEdit.
			Rect myrect = new Rect((Screen.width-100)/2, (Screen.height-100)/2, 200, 20);
			playerName = GUI.TextField (myrect, playerName, 25);
			
			myrect = new Rect((Screen.width-100)/2, (Screen.height-50)/2, 200, 30);
			if (GUI.Button(myrect,"Submit High Scores"))
			{
				//submit highscore
				submit = true;
//				StartCoroutine("SendScore",0);
//								Debug.Log("submit1");


				
			}
			 
		}
		
	}


	IEnumerator  SendScore()
	{
		Debug.Log("submit score here");
		yield return null;
	}

	
}
