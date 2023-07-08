using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using Traverser;

public class ActionHUD : MonoBehaviour
{ 
	// * --- Object References ---
	[Header("Pull up HUD reference")][SerializeField] GameObject PullUpHUDRef;
	[Header("Pull up HUD")][SerializeField] GameObject PullUpHUD;
	[Header("Drop down HUD reference")][SerializeField] GameObject DropDownHUDRef;
	[Header("Drop down HUD")][SerializeField] GameObject DropDownHUD;
	[Header("Aim HUD reference")][SerializeField] GameObject AimHUDRef;
	[Header("Aim HUD")][SerializeField] GameObject AimHUD;
	[Header("Player object")][SerializeField] GameObject Agent;
	
	// * --- HUD Variables ---
	
	// * --- HUD Safe Guard ---
	
	bool PullUpHUDisAvailable = false;
	bool DropDownHUDisAvailable = false;
	bool AimHUDisAvailable = false;
	
	void Start()
	{
		if(PullUpHUDRef != null && PullUpHUD != null) { PullUpHUDisAvailable = true; }
		if(DropDownHUDRef != null && DropDownHUD != null) { DropDownHUDisAvailable = true; }
		if(AimHUD != null && AimHUDisAvailable != null) { AimHUDisAvailable = true; }
	}
	
	void Update()
	{ 
		PullUpHUD.transform.position = Camera.main.WorldToScreenPoint(PullUpHUDRef.transform.position);
		
		DropDownHUD.transform.position = Camera.main.WorldToScreenPoint(DropDownHUDRef.transform.position);
		
	}
	
	// * -------------------
}
