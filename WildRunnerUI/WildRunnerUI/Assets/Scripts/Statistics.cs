using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statistics : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        //Basic Player Statistics check
        if (!PlayerPrefs.HasKey("TotalScore")) { PlayerPrefs.SetInt("TotalScore", 0); } else { PlayerPrefs.GetInt("TotalScore"); }
        if (!PlayerPrefs.HasKey("Progress")) { PlayerPrefs.SetString("Progress", "Not Played"); } else { PlayerPrefs.GetString("Progress"); }
        if (!PlayerPrefs.HasKey("Name")) { PlayerPrefs.SetString("Name", "WildRunner"); } else { PlayerPrefs.GetString("Name"); }

        //Settings Parameters check
        if (!PlayerPrefs.HasKey("ControlDevice")) { PlayerPrefs.SetInt("ControlDevice", 0); } else { PlayerPrefs.GetString("ControlDevice"); }
    }
}
