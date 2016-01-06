using UnityEngine;
using System.Collections;

public class enMove : MonoBehaviour {

	float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (1.2f,0f) , ForceMode2D.Force);
		//StartCoroutine (run ());

	}

//	IEnumerator run()
	//{
		//yield return new WaitForSeconds (1);
		//speed = Random.Range (1,10);
		//GetComponent<Rigidbody2D> ().AddForce (new Vector2 (speed,0f) , ForceMode2D.Force);
	//}

}
