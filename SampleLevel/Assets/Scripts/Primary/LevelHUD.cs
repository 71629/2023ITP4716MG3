using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelHUD : MonoBehaviour
{
	[SerializeField] GameObject FinishIndicator;
	[SerializeField] Transform Player, Finish;
	[SerializeField] Canvas Canvas;
	[SerializeField] Image Icon;
	[SerializeField] Color Color;
	[SerializeField] float Distance;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		// Find the UI position of the Finish Area
		Vector2 FinishPos = Camera.main.WorldToScreenPoint(Finish.position);
		// Draw the Finish Indicator on the Canvas according to FinishPos
		FinishIndicator.transform.position = FinishPos;
	}
}
