using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	[SerializeField] float BaseScore, TotalScore;
	[SerializeField] float Time, StandardTime;
	float[] Timer = new float[3];
	
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void StartLevel()
	{
		
	}
	
	// FinishLevel is called once the player enters the finish zone
	public void FinishLevel()
	{
		
	}
	
	public void RestartLevel()
	{
		
	}
	
	public void QuitLevel()
	{
		
	}
	
	private void OnTriggerEnter(Collider other) {
		if(other.gameObject.CompareTag("Finish"))
		{
			FinishLevel();
		}
	}
}
