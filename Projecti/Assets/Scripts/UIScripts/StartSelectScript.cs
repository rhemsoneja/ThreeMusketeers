using UnityEngine;
using System.Collections;

public class StartSelectScript : MonoBehaviour 
{
	//StartScreenCode============================================================
	public void StartOnClick() { Application.LoadLevel("SelectMenu"); }
	public void ExitOnClick()  { Application.Quit(); }

	//SelectScreenCode===========================================================
	public void SelectStartOnClick() { Application.LoadLevel("Home"); }
	public void SelectBackOnClick()  { Application.LoadLevel("StartMenu"); }

	//NeutralCode================================================================
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
}
