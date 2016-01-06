using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		StartCoroutine (wait ());
	}

	IEnumerator wait()
	{
		yield return new WaitForSeconds (1);
		Destroy (gameObject);
	}
}
