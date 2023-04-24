using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LevelSelectManager : MonoBehaviour
{
    [SerializeField] Button[] Levels;
    [SerializeField] Object LevelEntrance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1Entrance()
    {
        GameObject LevelInfo = Instantiate(LevelEntrance, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
        LevelInfo.GetComponent<LevelEntrance>().SetLevelInfo("Relics", "Relics.");
    }
}
