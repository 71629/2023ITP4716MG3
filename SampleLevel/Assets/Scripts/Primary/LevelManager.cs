using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[SerializeField] float BaseScore, TotalScore;
	[SerializeField] float Time, StandardTime;
	float[] Timer = new float[3];
	gameObject Player;
	Animator Canvas;
	
	// Start is called before the first frame update
	void Start()
	{
		Player = GameObject.FindWithTag("Player");
		Canvas = GameObject.FindWithTag("Canvas").GetComponent<Animator>();
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
}
