using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Lv2ResultScreen : MonoBehaviour
{
    float delay = 0;
    [SerializeField] int BaseScore, Aerobatics;
    [SerializeField] float TotalScore;
    int tempBaseScore, tempAerobatics, tempTimeBonus, tempTotalScore = 0;
    float tempScoreMultiplier = 0;
    [SerializeField] float ScoreMultiplier;
    [SerializeField] int Rating;
    [SerializeField] bool isLevelComplete;
    [SerializeField] float timers = -3;
    [SerializeField] int LevelID;
    [SerializeField] float TimeStore = 0;
    [SerializeField] TextMeshProUGUI Completion;
    [SerializeField] Animator Canvas;
    [SerializeField] TextMeshProUGUI BaseScoreText, AerobaticsText, TimeBonusText, ScoreMultiplierText, TotalScoreText;
    [SerializeField] GameObject NewRecordDisplay;
    [SerializeField] GameObject Enable, DisableTimer, DisableScoreDisplay, DisableVictoryScreen, DisableGameOverScreen, DisableButton1, DisableButton2, DisableButton3;
    [SerializeField] GameObject BlackBox;
    float TimeBonus;
    float score;
    bool check5, check4, check3, check2, check1;
    [SerializeField]GameObject Barrier4, Barrier3, Barrier2, Barrier1, Final, AnotherBlackBox;
    // Start is called before the first frame update
    [SerializeField] bool onceOnly = true, finalHitOne = true;
    void Start()
    {
        AnotherBlackBox.SetActive(false);
        //PlayerPrefs.SetInt("Level1HighScore", 0);
        Canvas.speed = 0;
        check5 = true;
        ScoreMultiplier = 0;
        onceOnly = true;
        finalHitOne = true;
    }

    // Update is called once per frame
    void Update()
    {




        if(Final == null)
        {
            check5 = false;
        }
        if (check5 == false)
        {
            Canvas.speed = 1;
            BlackBox.SetActive(true);
            AnotherBlackBox.SetActive(true);
            DisableGameOverScreen.SetActive(false);
            DisableTimer.SetActive(false);
            DisableScoreDisplay.SetActive(false);
            
            StartCoroutine(StartCounting());
            if (isLevelComplete)
            {
                Canvas.enabled = true;
                Completion.text = "<color=#77ffff>S<color=#ccffff>tage</color> <color=#77ffff>C<color=#ccffff>lear</color>";
            }

            else
            {
                Completion.text = "<color=#ff4444>S<color=#ff7777>tage</color> <color=#ff4444>F<color=#ff7777>ailed</color>";
            }
            Enable.SetActive(true);

            //}


        }
        else
        {
            BlackBox.SetActive(false);
        }

        TotalScore = (int)score;
        
        if (Final == null && finalHitOne == true)
        {
            finalHitOne = false;
            score = score + 1000;
            score = score * TimeBonus;
            score = score - timers;
            if(onceOnly == true)
            {
                ScoreMultiplier = -timers - 1;
                onceOnly = false;
            }
            
            check5 = false;
        }
        if (check5 == true)
        {
            timers += Time.deltaTime;

            if (timers >= 60)
            {
                TimeStore = 0.5f;
            }
            else if (timers >= 55)
            {
                TimeStore = 0.8f;

            }
            else if (timers >= 50)
            {
                TimeStore = 1f;
            }
            else if (timers >= 48)
            {
                TimeStore = 1.5f;
            }
            else if (timers <= 45)
            {
                TimeStore = 2f;
            }
        }
        BaseScore = 1000;
        Aerobatics = 2000;
        TotalScore = (int)score;
        Debug.Log(score);
        TimeBonus = TimeStore;
    }

    IEnumerator StartCounting()
    {
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(BaseScoreAnimation());
    }

    IEnumerator BaseScoreAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempBaseScore += (int)Mathf.Ceil((Time.deltaTime * BaseScore) / 1.2f);
        BaseScoreText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempBaseScore + "</size>";
        if (tempBaseScore >= BaseScore)
        {
            tempBaseScore = BaseScore;
            BaseScoreText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempBaseScore + "</size>";
            StartCoroutine(AerobaticsAnimation());
        }
        else
        {
            StartCoroutine(BaseScoreAnimation());
        }
    }

    IEnumerator AerobaticsAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempAerobatics += (int)Mathf.Ceil((Time.deltaTime * Aerobatics) / 1.2f);
        AerobaticsText.text = "<color=#aaaaaa>Aerobatics</color>\n<size=125>" + tempAerobatics + "</size>";
        if (tempAerobatics >= Aerobatics)
        {
            tempAerobatics = Aerobatics;
            AerobaticsText.text = "<color=#aaaaaa>Aerobatics</color>\n<size=125>" + tempAerobatics + "</size>";
            StartCoroutine(TimeBonusAnimation());
        }
        else
        {
            StartCoroutine(AerobaticsAnimation());
        }
    }

    IEnumerator TimeBonusAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempTimeBonus += (int)Mathf.Ceil((Time.deltaTime * TimeBonus) / 1.2f);
        TimeBonusText.text = "<color=#aaaaaa>Time Bonus</color>\n<size=125>" + "x" + TimeStore + "</size>";
        if (tempTimeBonus >= TimeBonus)
        {
            TimeBonusText.text = "<color=#aaaaaa>Time Bonus</color>\n<size=125>" + "x" + TimeStore + "</size>";
            StartCoroutine(ScoreMultiplierAnimation());
        }
        else
        {
            StartCoroutine(TimeBonusAnimation());
        }
    }

    IEnumerator ScoreMultiplierAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempScoreMultiplier += (int)Mathf.Ceil((Time.deltaTime * (int)ScoreMultiplier) / 1.2f);
        ScoreMultiplierText.text = "<color=#aaaaaa>Score Correction</color>\n<size=125>" + tempScoreMultiplier + "</size>";
        if (tempScoreMultiplier >= (int)ScoreMultiplier)
        {
            tempScoreMultiplier = (int)ScoreMultiplier;
            ScoreMultiplierText.text = "<color=#aaaaaa>Score Correction</color>\n<size=125>" + tempScoreMultiplier + "</size>";
            StartCoroutine(TotalScoreAnimation());
        }
        else
        {
            StartCoroutine(ScoreMultiplierAnimation());
        }
    }

    IEnumerator TotalScoreAnimation()
    {
        yield return new WaitForEndOfFrame();

        TotalScore = (int)score;
        tempTotalScore = (int)score;
        TotalScoreText.text = $"total score\n<size=250>{tempTotalScore}</size>";
        if (tempTotalScore >= TotalScore)
        {
            tempTotalScore = (int)TotalScore;
            TotalScoreText.text = $"total score\n<size=250>{tempTotalScore}</size>";
            if (TotalScore > PlayerPrefs.GetInt($"Level{LevelID}HighScore"))
            {
                PlayerPrefs.SetInt($"Level{LevelID}HighScore", (int)TotalScore);
                NewRecordDisplay.gameObject.SetActive(true);
                TotalScoreText.text = $"<color=#000000>total score\n<size=250>{tempTotalScore}</size></color>";
            }
        }
        else
        {
            StartCoroutine(TotalScoreAnimation());
        }
    }

    public void SetScore(int LevelID, bool isLevelComplete = false, int Rating = 0, int BaseScore = 0, int Aerobatics = 0, int TimeBonus = 0, float ScoreMultiplier = 1)
    {
        this.LevelID = LevelID;
        this.isLevelComplete = isLevelComplete;
        this.Rating = Rating;
        this.BaseScore = BaseScore;
        this.Aerobatics = Aerobatics;
        this.TimeBonus = TimeBonus;
        this.ScoreMultiplier = ScoreMultiplier;
    }
}