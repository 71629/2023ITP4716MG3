using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float time;
    [SerializeField] int BaseScore, Aerobatics, MaxTimeBonus;
    [SerializeField] float StandardTime;
    [SerializeField] int FlawCount;
    [SerializeField] CounterMode counterMode;
    [SerializeField] bool GameOverOnTimesUp;
    int minute = 0;

    [SerializeField] Text Timer;
    [SerializeField] Text MinuteDisplay;
    [SerializeField] Text Distance;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Target;

    [SerializeField] Object ResultScreen;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counterMode == (CounterMode)1)
        {
            StopCoroutine(CountDown());
            StartCoroutine(StopWatch());
        }
        if(counterMode == (CounterMode)2)
        {
            StopCoroutine(StopWatch());
            while (time >= 60)
            {
                time -= 60;
                minute++;
            }
            StartCoroutine(CountDown());
        }
        if(Player != null && Target != null)
        {
            Distance.text = Vector3.Distance(Player.transform.position, Target.transform.position).ToString("0.0") + 'm';
        }
    }

    public void Finish()
    {
        GameObject Result = Instantiate(ResultScreen, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
    }

    IEnumerator StopWatch()
    {
        yield return new WaitForEndOfFrame();

        time += Time.deltaTime;
        Timer.text = time.ToString("00.000");
        Timer.text = Timer.text.Insert(6, "</size></color>");
        Timer.text = Timer.text.Insert(2, "<color=#808080><size=150>");

        if (time >= 60)
        {
            time -= 60;
            minute++;
            MinuteDisplay.text = minute.ToString("00") + ':';
        }

        StartCoroutine(StopWatch());
    }

    IEnumerator CountDown()
    {
        yield return new WaitForEndOfFrame();

        time -= Time.deltaTime;
        Timer.text = time.ToString("00.000");
        Timer.text = Timer.text.Insert(6, "</size></color>");
        Timer.text = Timer.text.Insert(2, "<color=#808080><size=150>");

        if (time <= 0)
        {
            if(minute > 0)
            {
                time += 60;
                minute--;
                MinuteDisplay.text = minute.ToString("00") + ':';
                StartCoroutine(CountDown());
            }
            else
            {
                StopTimer();
            }
        }
    }

    public void StopTimer()
    {
        MinuteDisplay.text = "00:";
        if (counterMode == (CounterMode)1) { StopCoroutine(StopWatch()); }
        if (counterMode == (CounterMode)2) { StopCoroutine(CountDown()); }
        if (counterMode == (CounterMode)2)
        {
            Timer.text = "00<color=#808080><size=150>.000</size></color>";
        }
    }

    public enum CounterMode
    {
        StopWatch = 1, //Counts total time elasped since level start.
        CountDown = 2, //Counts down from a set time when level starts.
        Destination = 3, //Counts the distance between two GameObjects in meters.
    }
}
