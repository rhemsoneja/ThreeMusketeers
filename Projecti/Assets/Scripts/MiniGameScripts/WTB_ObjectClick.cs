using UnityEngine;
using System.Collections;

public class WTB_ObjectClick : MonoBehaviour 
{
	void OnMouseDown()
	{
		if(WTB_Gameplay.instance.scoreNum+1 == WTB_Gameplay.instance.maxObjects)
		{
			WTB_Gameplay.instance.setRound(WTB_Gameplay.instance.round+1);
		}
		else WTB_Gameplay.instance.addScore();

		this.gameObject.SetActive(false);
	}
}
