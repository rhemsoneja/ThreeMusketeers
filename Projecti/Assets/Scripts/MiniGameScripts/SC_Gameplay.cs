using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SC_Gameplay : MonoBehaviour 
{
	public Transform[] tilePos;
	public GameObject[] qnaPanel;

	public GameObject player;
	public Button diceBtn;
	public Text txtDice;
	int diceRoll = 0,prevTile = 0, sum;
	bool reached = false, endGame = false;

	public void rollDice()
	{
		if(!endGame)
		{
			diceRoll = Random.Range(1,7);
			txtDice.text = "Roll: " + diceRoll;
			txtDice.gameObject.SetActive(true);
			movePlayer(diceRoll);
		}
		else Debug.Log("Game End");
	}

	public void movePlayer(int roll)
	{
		sum = roll+prevTile;
		if(sum >= 20) {sum = 20; endGame = true;}
		reached = false;

		StartCoroutine(playerWalk());
	}

	IEnumerator playerWalk()
	{
		Vector3 tempPos = player.transform.position;
		if(prevTile+1 < sum) 
		{
			prevTile += 1;
			tempPos = tilePos[prevTile].position;
			player.transform.position = tempPos;
		}
		else
		{
			tempPos = tilePos[sum].position;
			player.transform.position = tempPos;
			prevTile = sum;
			Invoke("showPanel", 1);
			reached = true;
		}
		yield return new WaitForSeconds(0.3f);
		if(!reached) StartCoroutine(playerWalk());
	}

	void showPanel()
	{
		qnaPanel[sum].SetActive(true);
		diceBtn.gameObject.SetActive(false);
		txtDice.gameObject.SetActive(false);
	}

	public void closePanelRight()
	{
		qnaPanel[sum].SetActive(false);
		diceBtn.gameObject.SetActive(true);
		txtDice.gameObject.SetActive(false);
		//ADD RIGHT SHIT HERE
	}

	public void closePanelWrong()
	{
		qnaPanel[sum].SetActive(false);
		diceBtn.gameObject.SetActive(true);
		txtDice.gameObject.SetActive(false);
		//ADD WRONG SHIT HERE
	}
}
