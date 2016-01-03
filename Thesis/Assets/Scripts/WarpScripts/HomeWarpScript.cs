using UnityEngine;
using System.Collections;

public class HomeWarpScript : MonoBehaviour {

	public void OnGroundClick()
	{
		Application.LoadLevel("Floor_Ground");
	}
}
