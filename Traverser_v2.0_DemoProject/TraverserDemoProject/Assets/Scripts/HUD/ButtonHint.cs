using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHint : MonoBehaviour
{
	[SerializeField] GameObject ButtonIcon;
	[SerializeField] Text ActionDescription;
	
	public void SetUp(string displayText, string buttonDescription)
	{
		SetUpDisplayText(displayText);
		SetUpButtonDescription(buttonDescription);
	}
	
	void SetUpDisplayText(string buttonName)
	{
		ButtonIcon.GetComponentInChildren<Text>().text = buttonName;
	}
	
	void SetUpButtonDescription(string buttonDescription)
	{
		ActionDescription.text = buttonDescription;
	}
	
	public void EnableButtonHint()
	{
		ButtonIcon.GetComponent<Image>().color = new Color(1, 1, 1, 1);
		ButtonIcon.GetComponentInChildren<Text>().color = new Color(1, 1, 1, 1);
		ActionDescription.color = new Color(1, 1, 1, 1);
	}
	
	public void DisableButtonHint()
	{
		ButtonIcon.GetComponent<Image>().color = new Color(1, 1, 1, 0);
		ButtonIcon.GetComponentInChildren<Text>().color = new Color(1, 1, 1, 0);
		ActionDescription.color = new Color(1, 1, 1, 0);
	}
}
