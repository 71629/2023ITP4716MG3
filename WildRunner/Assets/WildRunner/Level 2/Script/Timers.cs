using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This cs is for timer control
//If final check point has been hit
//It will destroy the final check point
//If the final hit point not destroy, the timer will continue to count.


public class Timers : MonoBehaviour
{
    [SerializeField] TMP_Text timerDisplay;
    public float timer = -3f;
    public GameObject FinalPointNull, Victory;
    // Start is called before the first frame update
    void Start()
    {
        timer = -3;
    }

    // Update is called once per frame
    void Update()
    {
        if ((FinalPointNull != null && Victory != null) || timer >= -3) //Check did player hit final point
        {
            timer += Time.deltaTime;
            timerDisplay.text = timer.ToString("f1");
        }

    }
}
