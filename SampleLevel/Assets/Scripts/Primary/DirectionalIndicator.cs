using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionalIndicator : MonoBehaviour
{
	GameObject Player, Target;
	Text Distance;
	GameObject Icon, Background;
	bool isReady;
	
	// Start is called before the first frame update
	void Start()
	{
		Player = GameObject.FindWithTag("Player");
		isReady = false;
	}

	// Update is called once per frame
	void Update()
	{
		if(isReady)
		{
			// Display Indicator
			this.transform.position = Camera.main.WorldToScreenPoint(Target.transform.position);
			Distance.text = $"{Vector3.Distance(Player.transform.position, Target.transform.position):F0}m";
		}
	}
	
	public void SetIndicator(GameObject target, Sprite icon, Color color)
	{
		// Set up the indicator
		SetTarget(target);
		SetIcon(icon);
		SetBGColor(color);
		Distance = this.GetComponentInChildren<Text>();
		
		// Activate GameObject
		this.gameObject.SetActive(true);
		isReady = true;
	}
	
	// Make the Indicator invisible
	public void DisableIndicator()
	{
		this.gameObject.SetActive(false);
	}
	
	// Set the target for the indicator
	public void SetTarget(GameObject target)
	{
		Target = target;
	}
	
	// * Setters
	// Set the icon sprite for the indicator
	public void SetIcon(Sprite icon)
	{
		Icon.GetComponent<Image>().sprite = icon;
	}
	
	// Set the icon imag efor the indicator
	public void SetIcon(Color color)
	{
		Icon.GetComponent<Image>().color = color;
	}
	
	// Set the background color for the indicator
	public void SetBGColor(Color color)
	{
		Background.GetComponent<Image>().color = color;
	}
	
	// * Getters
	// Returns the target
	public GameObject GetTarget()
	{
		return Target;
	}
	
	// Returns the icon sprite
	public Sprite GetIconImage()
	{
		return Icon.GetComponent<Image>().sprite;
	}
	
	// Returns the icon color
	public Color GetIconColor()
	{
		return Icon.GetComponent<Image>().color;
	}
	
	// Returns the indicator background color
	public Color GetBGColor()
	{
		return Background.GetComponent<Image>().color;
	}
}
