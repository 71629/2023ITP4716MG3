using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using Traverser;

public class ActionHUD : MonoBehaviour
{ 
	Animator anim;
	void Start() // ! temporary
	{
		Time.timeScale = 0.3f;
		anim.SetTrigger
	}
	public void ButtonHintSetUp(TraverserParkourObject.TraverserParkourType parkourType)
	{
		
		
		// TODO: Refactor (Replace the switch statement) (line 13-30)
		switch(parkourType)
		{
			case TraverserParkourObject.TraverserParkourType.Ledge:
				GetComponent<Transform>().GetChild(0).GetComponent<ButtonHint>().SetUp("__", "Vault");
				break;
				
			case TraverserParkourObject.TraverserParkourType.Wall:
				GetComponent<Transform>().GetChild(0).GetComponent<ButtonHint>().SetUp("Q", "Climb");
				break;
				
			case TraverserParkourObject.TraverserParkourType.Table:
				GetComponent<Transform>().GetChild(0).GetComponent<ButtonHint>().SetUp("__", "Vault");
				break;
				
			case TraverserParkourObject.TraverserParkourType.Tunnel:
				GetComponent<Transform>().GetChild(1).GetComponent<ButtonHint>().SetUp("__", "Slide");
				break;
			
			default:
				break;
		}
	}
	
	void EnableButtonHint(GameObject target)
	{
		target.GetComponent<ButtonHint>().EnableButtonHint();
	}
	
	void DisableButtonHint(GameObject target)
	{
		target.GetComponent<ButtonHint>().DisableButtonHint();
	}
	
	string SetButtonHintText(string text)
	{
		return "";
	}
}
