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
    [SerializeField] Image LevelJacket;

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

    public void SetLevelInfo(string LevelName, string LevelDescription)
    {
        this.LevelName = LevelName;
        this.LevelDescription = LevelDescription;
        LevelNameGUI.text = LevelName;
        LevelDescriptionGUI.text = LevelDescription;
    }

    public void Exit()
    {
        GetComponent<Animator>().SetTrigger("Close");
    }

    public void Destroy()
    {
        Destroy(GameObject.Find("LevelEntrance(Clone)"));
    }
}
