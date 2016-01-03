using UnityEngine;
using System.Collections;

public class WarpElevatorScript : MonoBehaviour {

	public void OnGroundClick()
	{
		Application.LoadLevel("Floor_Ground");
	}
	
	public void OnThirdClick()
	{
		Application.LoadLevel("Floor_Academics");
	}
	
	public void OnFourthClick()
	{
		Application.LoadLevel("Floor_Fourth"); 
	}
	
	public void OnFifthClick()
	{
		Application.LoadLevel("Floor_Fifth");
	}
	
	public void OnSixthClick()
	{
		Application.LoadLevel("Floor_Library");
	}
	
	public void OnSeventhClick()
	{
		Application.LoadLevel("Floor_Seventh");
	}
}
