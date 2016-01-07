using UnityEngine;
using System.Collections;

public class MM_Ans: MonoBehaviour {

	public static bool add = false;
	public static bool sub = false;
	public static bool mul = false;
	public static bool dive = false;
	public static bool gre = false;
	public static bool les = false;
	public static bool equ = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
	void OnMouseDown() 
	{
		if (this.tag == "+") 
		{
			Debug.Log ("clicked +");
			add = true;
			sub = false;
			mul = false;
			dive = false;
			gre = false;
			les = false;
			equ = false;
		}
		
		if (this.tag == "-") 
		{
			Debug.Log ("clicked -");
			add = false;
			sub = true;
			mul = false;
			dive = false;
			gre = false;
			les = false;
			equ = false;
		}
		
		if (this.tag == "div") 
		{
			Debug.Log ("clicked /");
			add = false;
			sub = false;
			mul = false;
			dive = true;
			gre = false;
			les = false;
			equ = false;
		}
		

	}

}
