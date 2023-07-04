using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel : MonoBehaviour
{
		LevelEntrance LE;
		public void EnterStage1() { SceneManager.LoadScene("Level1"); }
		public void EnterStage0() { SceneManager.LoadScene("Level2"); }
}
