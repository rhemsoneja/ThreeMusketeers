using UnityEngine;
using System.Collections;

public class CNE_Gameplay : MonoBehaviour 
{
	public static CNE_Gameplay instance = null;
	public GameObject quest1, quest2, quest3, quest4, quest5, questArt1 , questArt2 , questArt3, questArt4 , questArt5;
	public int currentQuest = 0, quesRem = 5;
	bool one,two,thr,fou,fiv;

	void Start () 
	{
		Debug.Log("GAMEPLAY");
		if (instance == null) instance = this;
		SwitchQuestion();
	}

	void SwitchQuestion()
	{
		if(quesRem > 0)
		{
			currentQuest = Random.Range(0,5);
			Debug.Log("Switching to question: " + currentQuest);
			ShowNextQuestion();
		}
	}

	void ShowNextQuestion()
	{
		CloseAllQuestions();
		switch(currentQuest)
		{
			case 0: if(!one) { quest1.SetActive(true); questArt1.SetActive(true); one = true; quesRem--; CNE_AnswerPick.instance.ChangeButtonText(0); } else { SwitchQuestion(); } break;
			case 1: if(!two) { quest2.SetActive(true); questArt2.SetActive(true); two = true; quesRem--; CNE_AnswerPick.instance.ChangeButtonText(1); } else { SwitchQuestion(); } break;
			case 2: if(!thr) { quest3.SetActive(true); questArt3.SetActive(true); thr = true; quesRem--; CNE_AnswerPick.instance.ChangeButtonText(2); } else { SwitchQuestion(); } break;
			case 3: if(!fou) { quest4.SetActive(true); questArt4.SetActive(true); fou = true; quesRem--; CNE_AnswerPick.instance.ChangeButtonText(3); } else { SwitchQuestion(); } break;
			case 4: if(!fiv) { quest5.SetActive(true); questArt5.SetActive(true); fiv = true; quesRem--; CNE_AnswerPick.instance.ChangeButtonText(4); } else { SwitchQuestion(); } break;
			default: Debug.Log("ShowNextQuestion Error: currentQuest"); break;
		}

		Debug.Log("Activated question " + currentQuest + " successfully");
	}

	void CloseAllQuestions()
	{
		quest1.SetActive(false); quest2.SetActive(false); quest3.SetActive(false); quest4.SetActive(false); quest5.SetActive(false);
		questArt1.SetActive(false); questArt2.SetActive(false); questArt3.SetActive(false); questArt4.SetActive(false); questArt5.SetActive(false);
	}

	public void ReceiveAnswer(int ans)
	{
		SwitchQuestion();
		Debug.Log ("Answer received: " + ans);
		//Insert code here for points wether answer is "right" or "wrong"
	}

}
