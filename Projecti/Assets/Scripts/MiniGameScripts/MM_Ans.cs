using UnityEngine;
using System.Collections;

public class MM_Ans: MonoBehaviour {

	int answer;

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
			answer = 1;
		}
		
		if (this.tag == "-") 
		{
			Debug.Log ("clicked -");
			answer = 2;
		}
		
		if (this.tag == "*") 
		{
			Debug.Log ("clicked *");
			answer = 3;
		}

		if (this.tag == "div") 
		{
			Debug.Log ("clicked /");
			answer = 4;
		}
		answers ();

	}



	// ---------------------------- answer
	
	void answers()
	{
		switch (MM_Gameplay.ran) 
		{
		case 1:
			if(answer == 1)
			{
				MM_Gameplay.instance.correct();
				answer = 0;
			}
			else
			{
				MM_Gameplay.instance.wrong();
				answer = 0;
			}
			
			
			break;
			
		case 2:
			if(answer == 2)
			{
				MM_Gameplay.instance.correct();
				answer = 0;
			}
			else
			{
				MM_Gameplay.instance.wrong();
				answer = 0;
			}
			break;
			
		case 3:
			if(answer == 3)
			{
				MM_Gameplay.instance.correct();
				answer = 0;
			}
			
			else
			{
				MM_Gameplay.instance.wrong();
				answer = 0;
			}
			
			
			break;
			
		case 4:
			if(answer == 4)
			{
				MM_Gameplay.instance.correct();
				answer = 0;
			}
			
			else
			{
				MM_Gameplay.instance.wrong();
				answer = 0;
			}
			
			break;
		}
		
		
	}


}
