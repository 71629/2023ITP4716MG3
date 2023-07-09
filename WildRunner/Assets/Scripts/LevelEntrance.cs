using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class LevelEntrance : EnterLevel
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
		
		if(LevelID == 1)
        {
			this.LevelName = "Devil's Peak Battery";
			this.LevelDescription = "A British Hong Kong military base.";
			this.LevelJacket = LevelJacket;
		}
		if (LevelID == 2)
		{
			this.LevelName = "Dream City";
			this.LevelDescription = "After running in wild, a dream in his brain has been out come";
			this.LevelJacket = LevelJacket;
		}
	}

	public void Exit()
	{
		GetComponent<Animator>().SetTrigger("Close");
	}

	public void Destroy()
	{
		Destroy(GameObject.Find("LevelEntrance(Clone)"));
		Destroy(GameObject.Find("LevelEntrance - ½Æ»s(Clone)"));
	}
	
	public void StartLevel()
	{
		GetComponent<Animator>().SetTrigger("Close");
		StartCoroutine(CameraFX());
	}

	IEnumerator CameraFX()
	{
		yield return new WaitForSeconds(0.32f);
		if (LevelID == 0)
		{
			LevelID = 2;
		}

		GameObject.Find("Main Camera").GetComponent<Animator>().SetTrigger($"Stage{LevelID}");
		GameObject.Find("Canvas").GetComponent<Animator>().SetTrigger("ToStage");
	}
}
