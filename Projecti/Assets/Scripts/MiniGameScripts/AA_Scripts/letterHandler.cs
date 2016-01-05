// Alphabets Game Test : UnityCoder.com
using UnityEngine;
using System.Collections;

public class letterHandler : MonoBehaviour 
{
	
	public Transform explo;
	public AudioClip clip; // "damage" sound
	
	void Update () 
	{
		
		// check if we go outside the viewport
		Vector3 viewPos = Camera.main.WorldToViewportPoint(transform.position);
		if (viewPos.y<0)
		{
			// we are not destroyed?
			if (GetComponent<Renderer>().enabled) 
			{
				GetComponent<Renderer>().enabled = false;

				Camera.main.SendMessage("updateHP",-20, SendMessageOptions.DontRequireReceiver);
				Camera.main.SendMessage("FallOff",0, SendMessageOptions.DontRequireReceiver);

			}
			
			Transform clone = Instantiate(explo, transform.position+new Vector3(2,-1,0), Quaternion.identity) as Transform;
			Destroy(clone.gameObject,5);
			Destroy(gameObject);
			
			
			
		}
	
	}
}
