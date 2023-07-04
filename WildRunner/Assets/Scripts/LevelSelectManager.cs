using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
	[SerializeField] Button[] Levels;
	[SerializeField] Sprite[] LevelJackets;
	[SerializeField] Object LevelEntrance;
	[SerializeField] Object LevelEntrance2;
	[SerializeField] AudioSource clickPlayButtonSound;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		
	}
	
	public void Level0Entrance()
	{
		clickPlayButtonSound.Play();
		GameObject LevelInfo = Instantiate(LevelEntrance, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
		LevelInfo.GetComponent<LevelEntrance>().SetLevelInfo(2, "Testing Space", "This is a testing area for the game mechanics of WildRunner.\nIf you're seeing this, too bad.", LevelJackets[0]);
	}

	public void Level1Entrance()
	{
		clickPlayButtonSound.Play();
		GameObject LevelInfo = Instantiate(LevelEntrance, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
		LevelInfo.GetComponent<LevelEntrance>().SetLevelInfo(1, "Relics", "Relics.", LevelJackets[0]);
	}
	public void Level2Entrance()
	{
		clickPlayButtonSound.Play();
		GameObject LevelInfo = Instantiate(LevelEntrance2, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
		LevelInfo.GetComponent<LevelEntrance>().SetLevelInfo(2, "Relics", "Relics.", LevelJackets[0]);
	}

	public void BackToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}
