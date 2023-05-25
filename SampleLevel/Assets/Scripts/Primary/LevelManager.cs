using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[SerializeField] float BaseScore, TotalScore;
	[SerializeField] float Time, StandardTime;
	[SerializeField] Object DirectionalIndicator;
	[SerializeField] GameObject FinishArea;
	[SerializeField] Sprite FinishIcon;
	float[] Timer = new float[3];
	GameObject Player;
	Animator Canvas;
	
	// Start is called before the first frame update
	void Start()
	{
		Player = GameObject.FindWithTag("Player");
		if (Player == null)
		{
			Debug.LogError("No Player found!");
			return;
		}
		Canvas = GameObject.FindWithTag("Canvas").GetComponent<Animator>();
		if (Canvas == null)
		{
			Debug.LogError("No Canvas found!");
			return;
		}
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void StartLevel()
	{
		// Start the timer and show UIs
		// TODO: Design new UIs
		Canvas.SetTrigger("Start");
	}
	
	// FinishLevel is called once the player enters the finish zone
	public void FinishLevel()
	{
		// Calculate the score
		// TODO: Add a Time Bonus mechanic calculated with the StandardTime
		TotalScore = BaseScore + (Time - StandardTime);
		// Display the score
		Canvas.SetTrigger("Finish");
	}
	
	public void RestartLevel()
	{
		// * Changes might be required
		Canvas.SetTrigger("Restart");
	}
	
	public void QuitLevel()
	{
		// * Changes might be required
		Canvas.SetTrigger("Quit");
	}
	
	private void OnTriggerEnter(Collider other) {
		// If the player enters the finish zone
		if(other.gameObject.CompareTag("Finish"))
		{
			FinishLevel();
		}
	}

	private void DisplayFinishIndicator()
	{ 
		GameObject FinishIndicator = Instantiate(DirectionalIndicator, GameObject.Find("Canvas").transform) as GameObject;
		FinishIndicator.name = FinishIndicator.ToString();
	}
}
