using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.Assertions;
using Traverser;

public class ActionHUD : MonoBehaviour
{ 
	// * --- Object References ---
	[Header("HUD Position References")]
	[SerializeField] GameObject PullUpHUDReference;
	[SerializeField] GameObject DropDownHUDReference;
	[SerializeField] GameObject JumpBackHUDReference;
	[SerializeField] GameObject AimHUDReference;
	
	[Header("HUD Objects")]
	[SerializeField] GameObject PullUpHUD;
	[SerializeField] GameObject DropDownHUD;
	[SerializeField] GameObject JumpBackHUD;
	[SerializeField] GameObject AimHUD;
	
	[Header("Player Object")]
	[SerializeField] GameObject Agent;
	
	// * --- HUD Variables ---
	[Header("HUD Display Settings")]
	[Tooltip("HUD padding represented in percentage. Not recommended to go above 0.35f, anything higher than 0.5f results in assertion failure.")]
	public float HUDSafeZone = 0.1f;
	TraverserTransform ContactPosition;
	
	// * --- HUD Safe Guard ---
	
	bool PullUpHUDisAvailable = false;
	bool DropDownHUDisAvailable = false;
	bool JumpBackHUDisAvailable = false;
	bool AimHUDisAvailable = false;
	
	void Start()
	{	
		// * This statement transforms the canvas to the size and aspect ratio of the screen
		// * This allows the UI Safe Zone to work properly
		GetComponent<CanvasScaler>().referenceResolution = new Vector2(Screen.width, Screen.height);
		
		// * --- Check the integrity of the object reference sets ---
		// * Only when both of the reference and the HUD object is not null, the HUD displays
		if(PullUpHUDReference != null && PullUpHUD != null) { PullUpHUDisAvailable = true; } else { Debug.LogWarning("Pull up reference set is incomplete, pull up HUD is disabled.");}
		if(DropDownHUDReference != null && DropDownHUD != null) { DropDownHUDisAvailable = true; } else { Debug.LogWarning("Drop down reference set is incomplete, drop down HUD is disabled.");}
		if(JumpBackHUDReference != null && JumpBackHUD != null) { JumpBackHUDisAvailable = true; } else { Debug.LogWarning("Jump back reference set is incomplete, jump back HUD is disabled.");}
		if(AimHUDReference != null && AimHUD != null) { AimHUDisAvailable = true; } else { Debug.LogWarning("Aim reference set is incomplete, aim HUD is disabled.");}
	}
	
	// * --- Update position and draw UI elements ---
	void Update()
	{	
		Debug.Log(Agent.GetComponent<TraverserClimbingAbility>().GetState());
		
		// * --- HUD SZ Check ---
		// ! HUD SZ >= 0.5f ==> Assertion Failure
		Debug.Assert(HUDSafeZone < 0.5f, "HUD Safe Zone is higher than displayable limit. Value should always stay below 0.5f.");
		if (HUDSafeZone >= 0.35f) Debug.LogWarning("HUD Safe Zone is higher than recommended value.");
		
		// * --- Manage Pullup, Dropdown and Jumpback HUD visibility ---
		bool ElementVisible = Agent.GetComponent<TraverserClimbingAbility>().GetState() == TraverserClimbingAbility.ClimbingState.Climbing;
		PullUpHUD.SetActive(ElementVisible);
		DropDownHUD.SetActive(ElementVisible);
		JumpBackHUD.SetActive(ElementVisible);
		
		// * --- Manage Aim HUD visibility and function---
		RaycastHit hit;
		AimHUDReference.transform.position = Agent.GetComponent<TraverserCharacterController>().contactTransform.t;
		AimHUD.SetActive(Physics.Raycast(Agent.transform.position, Agent.transform.forward, out hit, 4, Agent.GetComponent<TraverserCharacterController>().characterCollisionMask, QueryTriggerInteraction.Ignore) && Agent.GetComponent<TraverserClimbingAbility>().GetState() == TraverserClimbingAbility.ClimbingState.Suspended);
		if(Physics.Raycast(Agent.transform.position, Agent.transform.forward, out hit, 4, Agent.GetComponent<TraverserCharacterController>().characterCollisionMask, QueryTriggerInteraction.Ignore))
		{
			if(hit.collider.gameObject.GetComponent<TraverserParkourObject>().type == TraverserParkourObject.TraverserParkourType.Wall){ AimHUD.GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(false); AimHUD.GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(true); } else { AimHUD.GetComponent<RectTransform>().GetChild(0).gameObject.SetActive(true); AimHUD.GetComponent<RectTransform>().GetChild(1).gameObject.SetActive(false); }
		}
		
		
		// * --- Update HUD screen position ---
		if(PullUpHUDisAvailable) { UpdateHUDPosition(PullUpHUD, PullUpHUDReference); }
		if(DropDownHUDisAvailable) { UpdateHUDPosition(DropDownHUD, DropDownHUDReference); }
		if(JumpBackHUDisAvailable) { UpdateHUDPosition(JumpBackHUD, JumpBackHUDReference); }
		if(AimHUDisAvailable) { UpdateHUDPosition(AimHUD, AimHUDReference); }
	}
	
	void UpdateHUDPosition(GameObject HUD, GameObject HUDReference)
	{
		HUD.transform.position = Camera.main.WorldToScreenPoint(HUDReference.transform.position);
		Vector3 pos = HUD.transform.position;
		pos.x = Mathf.Clamp(pos.x, HUDSafeZone * Screen.width, Screen.width - HUDSafeZone * Screen.width);
		pos.y = Mathf.Clamp(pos.y, HUDSafeZone * Screen.height, Screen.height - HUDSafeZone * Screen.height);
		HUD.transform.position = pos;
	}
	
	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube(PullUpHUDReference.transform.position, new Vector3(0.1f, 0.1f, 0.1f));
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(DropDownHUDReference.transform.position, new Vector3(0.1f, 0.1f, 0.1f));
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(JumpBackHUDReference.transform.position, new Vector3(0.1f, 0.1f, 0.1f));
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube(AimHUDReference.transform.position, new Vector3(0.1f, 0.1f, 0.1f));
	}
}
