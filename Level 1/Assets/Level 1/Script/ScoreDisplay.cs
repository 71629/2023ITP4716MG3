using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour

{
    [SerializeField] TMP_Text scoreDisplay;
    public float score = 3000f; // 4 Aerobatics + 1 Base Score
    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString("f0");
    }
}