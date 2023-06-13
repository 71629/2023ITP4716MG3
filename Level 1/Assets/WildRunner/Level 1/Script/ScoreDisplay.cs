using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public GameObject Barrier1, Barrier2, Barrier3, Barrier4, Final, Victory, GameOver, Player;
    public float TimeBonus = 2f;
    [SerializeField] TMP_Text scoreDisplay;
    public float score = 0f;
    public float timer = 0f;
    public bool check1 = true, check2 = true, check3 = true, check4 = true, check5 = true, VictoryTF=true;
    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString("f0");

        if(Victory == null && VictoryTF == true) //If canvas victory destroy, then stop timer then game over.
        {
            VictoryTF = false;
            score = score - timer;
            //No bonus
        }
        else if(check5 == true)
        {
            GameTimer();//Timer will stop when hit final point
        }
        
        if (Barrier1 == null && check1 == true)
        {
            check1 = false;
            score = score + 500;
        }
        if (Barrier2 == null && check2 == true)
        {
            check2 = false;
            score = score + 500;
        }
        if (Barrier3 == null && check3 == true)
        {
            check3 = false;
            score = score + 500;
        }
        if (Barrier4 == null && check4 == true)
        {
            check4 = false;
            score = score + 500;
        }
        if (Final == null && check5 == true)
        {
            check5 = false;
            score = score + 1000;
            score = score * TimeBonus - timer;
            Destroy(Player);
        }
        if(Victory == null)
        {
            GameOver.SetActive(true);
        }
    }
    void GameTimer() //Calculate and display time + Give time bonus
    {
        timer += Time.deltaTime;

        if (timer >= 60)
        {
            TimeBonus = 0.2f;
        }
        else if (timer >= 55)
        {
            TimeBonus = 0.5f;

        }
        else if (timer >= 50)
        {
            TimeBonus = 0.8f;
        }
        else if (timer >= 48)
        {
            TimeBonus = 1f;
        }
        else if (timer >= 45)
        {
            TimeBonus = 1.5f;
        }

    }
}