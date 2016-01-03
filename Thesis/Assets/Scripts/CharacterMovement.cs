using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour 
{
	float conSpeed = 5f;

	void Start () 
	{
	
	}

	void FixedUpdate () 
	{
		Vector3 newPos = this.transform.position;
		if(Input.GetKey(KeyCode.W))
		{
			newPos.z += conSpeed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S))
		{
			newPos.z -= conSpeed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A))
		{
			newPos.x -= conSpeed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.D))
		{
			newPos.x += conSpeed * Time.deltaTime;
		}

		transform.position = newPos;
	}
}
