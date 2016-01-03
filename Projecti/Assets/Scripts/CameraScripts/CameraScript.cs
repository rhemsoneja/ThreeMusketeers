using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	public GameObject target;
	float x,y,z;

	void Awake()
	{
		x = this.transform.position.x;
		y = this.transform.position.y;
		z = this.transform.position.z;
	}

	void FixedUpdate () 
	{
		Vector3 newPos = new Vector3(x,y,z);
		newPos.x = target.transform.position.x;
		newPos.z = target.transform.position.z - 5f ;

		this.transform.position = newPos;
	}
}
