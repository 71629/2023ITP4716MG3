using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //Basic Player Statistics check
        if (!PlayerPrefs.HasKey("TotalScore")) { PlayerPrefs.SetInt("TotalScore", 0); }
        if (!PlayerPrefs.HasKey("Progress")) { PlayerPrefs.SetString("Progress", "Not Played"); }
        if (!PlayerPrefs.HasKey("Name")) { PlayerPrefs.SetString("Name", "WildRunner"); }

        //Settings Parameters check
        if (!PlayerPrefs.HasKey("ControlDevice")) { PlayerPrefs.SetInt("ControlDevice", 0); }
        if (!PlayerPrefs.HasKey("MasterVolume")) { PlayerPrefs.SetFloat("MasterVolume", 1); }
        if (!PlayerPrefs.HasKey("MusicVolume")) { PlayerPrefs.SetFloat("MusicVolume", 1); }
        if (!PlayerPrefs.HasKey("VoiceVolume")) { PlayerPrefs.SetFloat("VoiceVolume", 1); }
        if (!PlayerPrefs.HasKey("SFXVolume")) { PlayerPrefs.SetFloat("SFXVolume", 1); }
        if (!PlayerPrefs.HasKey("DefaultDifficulty")) { PlayerPrefs.SetInt("DefaultDifficulty", 1); }

        if (!PlayerPrefs.HasKey("Level1HighScore")) { PlayerPrefs.SetInt("Level1HighScore", 0); }
        if (!PlayerPrefs.HasKey("Level2HighScore")) { PlayerPrefs.SetInt("Level2HighScore", 0); }
        if (!PlayerPrefs.HasKey("Level3HighScore")) { PlayerPrefs.SetInt("Level3HighScore", 0); }
    }
}
