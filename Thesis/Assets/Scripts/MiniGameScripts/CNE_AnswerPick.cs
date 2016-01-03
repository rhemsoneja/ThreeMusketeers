using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CNE_AnswerPick : MonoBehaviour 
{
	public static CNE_AnswerPick instance = null;
	public Text cA, cB, cC, cD;

	void Awake()
	{
		Debug.Log("ANSWERPICK");
		if(instance == null) instance = this;
	}

	public void ChangeButtonText(int i)
	{
		switch(i)
		{
		case 0:cA.text = "A) ";
				cB.text = "B) ";
				cC.text = "C) ";
				cD.text = "D) ";
				break;
		case 1: cA.text = "A) Take the Pill";
				cB.text = "B) Give to Friend";
				cC.text = "C) Insist No one take it";
				cD.text = "D) Split it in half";
				break;
		case 2: cA.text = "A) Jenny";
				cB.text = "B) Nagini";
				cC.text = "C) Victor";
				cD.text = "D) Rais";
				break;
		case 3: cA.text = "A) Take the Money";
				cB.text = "B) Leave it Be";
				cC.text = "C) Give it to someone else";
				cD.text = "D) Return the money";
				break;
		case 4: cA.text = "A) Convict the robber";
				cB.text = "B) Do not convict";
				cC.text = "C) ";
				cD.text = "D) ";
				break;
		default: break;
		}
	}

	public void choiceA()
	{
		CNE_Gameplay.instance.ReceiveAnswer(0);
	}

	public void choiceB()
	{
		CNE_Gameplay.instance.ReceiveAnswer(1);
	}

	public void choiceC()
	{
		CNE_Gameplay.instance.ReceiveAnswer(2);
	}

	public void choiceD()
	{
		CNE_Gameplay.instance.ReceiveAnswer(3);
	}
}
