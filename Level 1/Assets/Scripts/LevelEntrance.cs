using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelEntrance : MonoBehaviour
{
	[SerializeField] int LevelID;

	[SerializeField] string LevelName;
	[SerializeField] string LevelDescription;
	[SerializeField] Sprite LevelJacket;

	[SerializeField] Text LevelNameGUI, LevelDescriptionGUI, HighScoreGUI;

	// Start is called before the first frame update
	void Start()
	{
		LevelNameGUI.text = LevelName;
		LevelDescriptionGUI.text = LevelDescription;
		HighScoreGUI.text = $"High Score: <size=72><b>{PlayerPrefs.GetInt($"Level{LevelID}HighScore")}</b></size>";
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	public void SetLevelInfo(int LevelID, string LevelName, string LevelDescription, Sprite LevelJacket)
	{
		this.LevelID = LevelID;
		this.LevelName = LevelName;
		this.LevelDescription = LevelDescription;
		LevelNameGUI.text = LevelName;
		LevelDescriptionGUI.text = LevelDescription;
		this.LevelJacket = LevelJacket;
		if(LevelID == 1)
        {
			this.LevelName = "Devil's Peak Battery";
			this.LevelDescription = "A British Hong Kong military base.";
		}
	}

	public void Exit()
	{
		GetComponent<Animator>().SetTrigger("Close");
	}

	public void Destroy()
	{
		Destroy(GameObject.Find("LevelEntrance(Clone)"));
	}
	
	public void StartLevel()
	{
		GetComponent<Animator>().SetTrigger("Close");
		StartCoroutine(CameraFX());
	}
	
	IEnumerator CameraFX()
	{
		yield return new WaitForSeconds(0.32f);
		
		GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger($"Stage{LevelID}");
		GameObject.Find("Canvas").GetComponent<Animator>().SetTrigger("ToStage");	
	}
}
