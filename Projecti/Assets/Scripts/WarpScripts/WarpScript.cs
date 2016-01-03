using UnityEngine;
using System.Collections;

public class WarpScript : MonoBehaviour 
{
	public GameObject warpUI;

	void Start () 
	{
		warpUI.SetActive(false);
	}

	void OnTriggerEnter(Collider col)
	{
		warpUI.SetActive(true);
	}

	void OnTriggerExit(Collider col)
	{
		warpUI.SetActive(false);
	}

	//Button Commands

	public void OnUiClose()
	{
		warpUI.SetActive(false);
	}
}
