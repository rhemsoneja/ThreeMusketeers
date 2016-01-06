using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	private Transform target;
	Vector3 targetposition;
	float distance = -10;
	float height;

	// Use this for initialization
	void Start () 
	{
		target = GameObject.Find ("run2_0").transform;
	}
	
	// Update is called once per frame
	void Update () {
	
		targetposition = target.position - target.right;
		targetposition = new Vector3 (target.position.x, height, distance);
		transform.position = targetposition;
	}
}



