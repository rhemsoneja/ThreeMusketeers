using UnityEngine;
using System.Collections;

public class SelectedScript : MonoBehaviour 
{
	public GameObject self;
	public GameObject other;

	void OnMouseDown()
	{
		Color visible = new Color(1, 1, 1, 1);
		Color invisible = new Color(1, 1, 1, 0);

		if(this.tag == "Female")
		{
			Debug.Log("fem");
			self.GetComponent<SpriteRenderer>().color = visible;
			other.GetComponent<SpriteRenderer>().color = invisible;
		}

		if(this.tag == "Male")
		{
			Debug.Log("male");
			self.GetComponent<SpriteRenderer>().color = visible;
			other.GetComponent<SpriteRenderer>().color = invisible;
		}
	}
}
