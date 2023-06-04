using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1EndGame : MonoBehaviour
{
    [Header("Base Score")]
    [Tooltip("Score to be added when the player reach the finish zone")]
    [SerializeField] float BaseScore = 1000f; //Base score 1000 mark while finish

    [Header("Aerobatics")]
    [Tooltip("Score to be added when the player successfully perform aerobatics")]
    [SerializeField] float Aerobatics = 500f; //Each aerobatics + 500 score

    [Header("Time Bonus")]
    [Tooltip("Stop decreasing when the player finishes the level")]
    [SerializeField] float TimeBonus = 2f; //Base 2x time bonus

    public float TotalScore = 0, timer = -0.5f; //Timer -0.5 because of loading screen delay 0.5 second start

    public GameObject AerobaticsType1, AerobaticsType2, AerobaticsType3, AerobaticsType4, FinishLine;
    
    //This trigger is to note did the player trigger the point.
    public bool Trigger1 = true, Trigger2 = true, Trigger3 = true, Trigger4 = true, FTrigger = true;
    
    // Update is called once per frame
    void Update()
    {
        //If trigger the end point it will stop the timer.
        if(FTrigger == true)
        {
            GameTimer();
        }
    }

    //Timer for calculate playing time and give the bonus (Default Bonus = 2f)
    void GameTimer()
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

    //void OnTriggerEnter(Colider col) Comment
    //Each aerobatics have trigger point
    //After trigger once will disable the trigger point
    //Point will add into TotalScore
    //Final Point will add 1000 in to TotalScore
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            //If trigger
            if(Trigger1 == true)
            {
                //Add 500 aerobatics point to TotalScore
                TotalScore = TotalScore + Aerobatics;  
                //Disable the trigger
                AerobaticsType1.SetActive(false);
                //Note trigger1 is disable (false)
                Trigger1 = false;   
                Debug.Log("Point 1: " + TotalScore);    //Debug show now score
            } 
            else if (Trigger2 == true)
            {
                TotalScore = TotalScore + Aerobatics;
                AerobaticsType2.SetActive(false);
                Trigger2 = false;
                Debug.Log("Point 2: " + TotalScore);
            }
            else if (Trigger3 == true)
            {
                TotalScore = TotalScore + Aerobatics;
                AerobaticsType3.SetActive(false);
                Trigger3 = false;
                Debug.Log("Point 3: " + TotalScore);
            }
            else if (Trigger4 == true)
            {
                TotalScore = TotalScore + Aerobatics;
                AerobaticsType4.SetActive(false);
                Trigger4 = false;
                Debug.Log("Point 4: " + TotalScore);
            }
            else if (FTrigger == true)
            {
                TotalScore = (TotalScore + BaseScore) * TimeBonus;
                FinishLine.SetActive(false);
                FTrigger = false;
                Debug.Log("Final Score: " + TotalScore);
            }

        }
    }
}
