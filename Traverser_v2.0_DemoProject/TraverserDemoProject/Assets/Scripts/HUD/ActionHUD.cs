using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using Traverser;

public class ActionHUD : MonoBehaviour
{ 
	// * Functions used to detect key presses and find button hints by display text
	private readonly Dictionary<Key, string> keyToDisplayText = new Dictionary<Key, string>
	{
		{ Key.Q, "Q" },
		{ Key.E, "E" },
		{ Key.Space, "__" },
		{ Key.LeftShift, "LS"}
	};

	void Update()
	{	
		
		foreach (var kvp in keyToDisplayText)
		{
			if (Keyboard.current[kvp.Key].wasPressedThisFrame)
			{
				FindButtonHintsByDisplayText(kvp.Value);
			}
		}
		
		// TODO: Add button hints for PullUp and DropDown
		
		// ! Debugging code
		Debug.Log($"Current Traverser climbing state: {GameObject.Find("Agent").GetComponent<TraverserClimbingAbility>().GetState()}");  
	}

	void FindButtonHintsByDisplayText(string displayText)
	{
		ButtonHint[] buttonHints = GetComponentsInChildren<ButtonHint>();
		foreach (ButtonHint buttonHint in buttonHints)
		{
			if (buttonHint.GetDisplayText() == displayText)
			{
				// Code to execute when a button hint with the same displayText is found
				GetComponentInChildren<ButtonHint>().DisableButtonHint();
			}
		}
	}
	
	// * Functions used to set up button hints
	private readonly Dictionary<TraverserParkourObject.TraverserParkourType, (string, string)> buttonHintSetups = new Dictionary<TraverserParkourObject.TraverserParkourType, (string, string)>
	{
		{ TraverserParkourObject.TraverserParkourType.Ledge, ("__", "Vault") },
		{ TraverserParkourObject.TraverserParkourType.Wall, ("Q", "Climb") },
		{ TraverserParkourObject.TraverserParkourType.Table, ("__", "Vault") },
		{ TraverserParkourObject.TraverserParkourType.Tunnel, ("__", "Slide") }
	};

	public void ButtonHintSetUp(TraverserParkourObject.TraverserParkourType parkourType)
	{
		if (buttonHintSetups.TryGetValue(parkourType, out var setup))
		{
			GetComponent<Transform>().GetChild(0).GetComponent<ButtonHint>().SetUp(setup.Item1, setup.Item2);
			GetComponent<Transform>().GetChild(0).GetComponent<ButtonHint>().EnableButtonHint();
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
}
