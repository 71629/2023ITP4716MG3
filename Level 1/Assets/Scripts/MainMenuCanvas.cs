using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuCanvas : MonoBehaviour
{
    public void ToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
