using UnityEngine;
using System.Collections;

public class MM_Gameplay : MonoBehaviour {
	public static MM_Gameplay instance =null;
	public GUIText time;
	public GUIText question;
	public GUIText life;
	public GUIText elife;
	public GUIText result;
	public int lifex;
	public int lifey;
	string res;
	int timer =0;
	public static int ran;

	//int plusRan;
	//int minusRan;
	//int multiRan;
	//int divideRan;
	float num1;
	float num2;
	float num3;


	void Awake()
	{
		if (instance == null)
			instance = this;
	}
	
	void Start () 
	{

	}

	void Update () 
	{
		play ();

	}



	//----------------------------question
	void questions()
	{
		switch (ran) 
		{
		case 1:
			Debug.Log ("+");
			num1 = Random.Range(0,10);
			num2 = Random.Range(0,10);
			num3 = num1 + num2;
			question.text = num1 + " __ "+ num2 +" = " + num3 ;
			break;
		case 2:
			Debug.Log ("-");
			num1 = Random.Range(0,10);
			num2 = Random.Range(0,10);
			num3 = num1 - num2;
			question.text = num1 + " __ "+ num2 +" = " + num3 ;
			
			break;
		case 3:
			Debug.Log ("*");
			num1 = Random.Range(0,10);
			num2 = Random.Range(0,10);
			num3 = num1 * num2;
			question.text = num1 + " __ "+ num2 +" = " + num3 ;
			break;
		case 4:
			Debug.Log ("/");
			num1 = Random.Range(0,10);
			num2 = Random.Range(0,10);
			num3 = num1 / num2;
			question.text = num1 + " __ "+ num2 +" = " + num3 ;
			break;
			
		default:
			ran = Random.Range(0,6);
			break;
		}



	}


	void play ()
	{
		timer--;
		if (timer < 0) 
		{
			timer = 1000;
			lifex--;
			ran = Random.Range (0, 5);
			questions ();
		}
		time.text = "Time " + timer;
		life.text = "Life " + lifex;
		elife.text = lifey + " ELife";
	

	}
	public void correct()
	{
		timer = 1000;

		lifey--;
		result.text = "result :" + "correct";
		ran = Random.Range (0, 5);
	}
	
	public void wrong()
	{
		timer = 1000;

		lifex--;
		result.text = "result :" + "wrong";
		ran = Random.Range (0, 5);
	}



}
