using UnityEngine;
using System.Collections;

public class MM_Gameplay : MonoBehaviour {

	public GUIText time;
	public GUIText question;
	public GUIText life;
	public GUIText elife;
	public int lifex = 10;
	public int lifey = 10;

	int timer =100;
	int ran;
	int a = 0;
	int b = 0;

	void Awake()
	{

	}

	

	void Start () 
	{

	}

	void Update () 
	{
		timer--;
		if (timer < 0) 
		{
			timer = 100;
			ran = Random.Range (0, 5);
		}
		a++;
		b++;
		time.text = "Time " + timer;
		life.text = "Life " + lifex;
		elife.text = lifey + " ELife";
		questions ();
		answers ();

		Debug.Log ("add " + MM_Ans.add);
		Debug.Log ("sub " + MM_Ans.sub);
		Debug.Log ("mul " + MM_Ans.mul);
		Debug.Log ("div ===" + MM_Ans.dive);
		
	}



	//----------------------------question
	void questions()
	{

		if (ran == 1) 
		{
			question.text = "1 _ 2 = 3";
		}
		if (ran == 2) 
		{
			question.text = "3 _ 2 = 1";
		}
		if (ran == 3) 
		{
			question.text = "2 _ 2 = 1";
		}
		if (ran == 4) 
		{
			question.text = "5 _ 5 = 25";
		}
		
	}

	// ---------------------------- answer

	void answers()
	{
		if (MM_Ans.add == false || MM_Ans.sub == false || MM_Ans.mul == false || MM_Ans.dive == false) 
		{
			if (ran == 1 && MM_Ans.add == true) 
			{
					--lifey;
					MM_Ans.add = false;
					timer = 100;
					ran = Random.Range (0, 5);
			}
			else
			
			if (ran == 1 && MM_Ans.sub == true || MM_Ans.mul == true || MM_Ans.dive == true) 
			{
				--lifex;
				MM_Ans.sub = false;
				MM_Ans.mul = false;
				MM_Ans.dive = false;
				timer = 100;
				ran = Random.Range (0, 5);
			}

			else
			if (ran == 2 && MM_Ans.sub == true) 
			{
				--lifey;
				MM_Ans.sub = false;
				timer = 100;
				ran = Random.Range (0, 5);
			}
			else
				
				if (ran == 2 && MM_Ans.add == true || MM_Ans.mul == true || MM_Ans.dive == true) 
			{
				--lifex;
				MM_Ans.add = false;
				MM_Ans.mul = false;
				MM_Ans.dive = false;
				timer = 100;
				ran = Random.Range (0, 5);
			}

			else
			if (ran == 3 && MM_Ans.dive == true) 
			{
				--lifey;
				MM_Ans.dive = false;
				timer = 100;
				ran = Random.Range (0, 5);
			}

			else
				if (ran == 3 && MM_Ans.add == true || MM_Ans.mul == true || MM_Ans.sub == true) 
			{
				--lifex;
				MM_Ans.add = false;
				MM_Ans.mul = false;
				MM_Ans.sub = false;
				timer = 100;
				ran = Random.Range (0, 5);
			}

		}
	}




}
