using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	float distance=-10;
	float horizontal;
	float jump = 30f;
	float speed;
	float move =0;
	float a = 0;
	float b = 0;
	float c = 0;
	float d = 0;
	Animator anim;
	//int speedId = Animator.StringToHash("speed");
	//int jumpId = Animator.StringToHash("jump");
	// Use this for initialization
	void Start () 
	{
		//anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (4.7f,0f) , ForceMode2D.Force);
		if (Input.GetKeyDown (KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().AddForce (Vector2.up *300, ForceMode2D.Force);	
			//anim.SetFloat (jumpId, jump);
		}



		//StartCoroutine(control ());


			//Debug.Log(speed);

		//anim.SetFloat(speedId,move);

	}

//	IEnumerator control()
	//{
		//yield return new WaitForSeconds (1);
		//if (Input.GetKeyDown (KeyCode.A))
		//{
		//	a++;
		//}
		//if (Input.GetKeyDown (KeyCode.Z))
		//{
		//	b++;
		//}
		//if (a>1 && b>1)
		//{
		//	c++;
		//}
	//	if (c > 2) 
		//{
			
		//	speed = 200f;
			//	move = gameObject.transform.localPosition.x;
			//GetComponent<Rigidbody2D> ().AddForce (new Vector2 (speed,0f) , ForceMode2D.Force);
			//anim.SetFloat (speedId, jump);
			
		//	a = 0;
		//	b = 0;
		//	d++;
		//} 
		//if (d > 3)
		//{
		//	c=0;
		//}
		
		//else
		//	if (c < 1) 
		//{
			
		//	GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		//}
	//}
}
