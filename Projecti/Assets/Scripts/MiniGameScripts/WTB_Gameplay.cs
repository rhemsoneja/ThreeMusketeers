using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WTB_Gameplay : MonoBehaviour 
{
	public static WTB_Gameplay instance = null;
	public GameObject roundOne, roundTwo, roundThree;
	public Text txtScore, txtRound;
	public int scoreNum, maxObjects, round;
	void Start () 
	{
		if (instance == null) instance = this;

		scoreNum = 0;
		maxObjects = 5;
		round = 1;

		txtScore.text = "SCORE: " + scoreNum + "/" + maxObjects;
		txtRound.text = "ROUND" + round;

		setRound(1);
	}

	void Update () 
	{
		txtScore.text = "SCORE: " + scoreNum + "/" + maxObjects;
		txtRound.text = "ROUND " + round;
	}

	public void setRound(int i)
	{
		if(i == 1)
		{
			roundOne.SetActive(true);roundTwo.SetActive(false);roundThree.SetActive(false);

		}
		else if(i==2)
		{
			roundOne.SetActive(false);roundTwo.SetActive(true);roundThree.SetActive(false);
			scoreNum = 0;
			maxObjects = 8;
			round = 2;
		}
		else if(i==3)
		{
			roundOne.SetActive(false);roundTwo.SetActive(false);roundThree.SetActive(true);
			scoreNum = 0;
			maxObjects = 10;
			round = 3;
		}
		else
		{
			Debug.Log("END!!!");
		}
	}

	public void addScore()
	{
		scoreNum++;
	}
}
