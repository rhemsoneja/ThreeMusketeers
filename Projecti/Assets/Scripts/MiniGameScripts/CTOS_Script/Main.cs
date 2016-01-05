using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
	public GameObject bu1;
	public GameObject bu2;
	public GameObject bu3;
	public GameObject bu1a;
	public GameObject bu1b;
	public GameObject bu1c;
	public GameObject bu2a;
	public GameObject bu2b;
	public GameObject bu2c;
	public GameObject bu3a;
	public GameObject bu3b;
	public GameObject bu3c;
	public GameObject light1;
	public GameObject light2;
	public GameObject light3;
	public GameObject flight;
	public static bool pressedb1 = false;
	public static bool pressedb2 = false;
	public static bool pressedb3 = false;
	float speed = 45f;
	float a = 1;
	float b = -1;
	float c = 1;
	float num1 = 0;
	float num2 = 0;
	float num3 = 0;
	float num4 = 0;

	void Start () 
	{
		Color trans1 = new Color(1,1,1, num1);
		Color trans2 = new Color(1,1,1, num2);
		Color trans3 = new Color(1,1,1, num3);
		Color trans4 = new Color(1,1,1, num4);
		light1.GetComponent<SpriteRenderer>().color = trans1;
		light2.GetComponent<SpriteRenderer>().color = trans2;
		light3.GetComponent<SpriteRenderer>().color = trans3;
		flight.GetComponent<SpriteRenderer>().color = trans4;
	}
	
	void Update () 
	{
		press ();
		correct ();
		Debug.Log (bu3.transform.eulerAngles.z);
	}

	void press()
	{
		if (pressedb1) 
		{
			rotateb1 ();
			pressedb1 = false;
		}
		
		if (pressedb2) 
		{
			rotateb2 ();
			pressedb2 = false;
		}

		if (pressedb3) 
		{
			rotateb3 ();
			pressedb3 = false;
		}
	}





	void rotateb1()
	{
		bu1.transform.Rotate (Vector3.forward * 45 * a);

		bu1a.transform.Rotate (Vector3.forward * 45 * a);

		bu1b.transform.Rotate (Vector3.forward * 45 * a);

		bu1c.transform.Rotate (Vector3.forward * 45 * a);
	}

	void rotateb2()
	{
		bu2.transform.Rotate (Vector3.forward * 20 * b);

		bu2a.transform.Rotate (Vector3.forward * 45 * b);
		
		bu2b.transform.Rotate (Vector3.forward * 45 * b);
		
		bu2c.transform.Rotate (Vector3.forward * 45 * b);
		
	}

	void rotateb3()
	{
		bu3.transform.Rotate (Vector3.forward * 20 * c);
		
		bu3a.transform.Rotate (Vector3.forward * 45 * c);
		
		bu3b.transform.Rotate (Vector3.forward * 45 * c);
		
		bu3c.transform.Rotate (Vector3.forward * 45 * c);
		
	}

	void correct()
	{

		if (bu1.transform.eulerAngles.z > 269) 
		{
			num1 = 1;
			a=0;
			Color trans1 = new Color(1,1,1, num1);

			light1.GetComponent<SpriteRenderer>().color = trans1;

		}

		if (bu2.transform.eulerAngles.z < 143) 
		{
			num2 = 1;
			Color trans2 = new Color(1,1,1, num2);
			light2.GetComponent<SpriteRenderer>().color = trans2;

			b=0;
		}
		if (bu3.transform.eulerAngles.z > 209) 
		{
			num3 = 1;
			Color trans3 = new Color(1,1,1, num3);
			light3.GetComponent<SpriteRenderer>().color = trans3;
			c=0;
		}

		if (a==0 && b==0 && c==0)
		{
			num4 = 4;
			Debug.Log("win");
			Color trans4 = new Color(1,1,1, num3);
			flight.GetComponent<SpriteRenderer>().color = trans4;
		}
	}

}
