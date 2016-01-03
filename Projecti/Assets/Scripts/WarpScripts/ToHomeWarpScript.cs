using UnityEngine;
using System.Collections;

public class ToHomeWarpScript : MonoBehaviour {

	public void OnHomeClick()
	{
		Application.LoadLevel("Home");
	}
}
