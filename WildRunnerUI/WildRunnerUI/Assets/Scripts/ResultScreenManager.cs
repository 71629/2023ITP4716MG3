using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class ResultScreenManager : MonoBehaviour
{
    [SerializeField] int BaseScore, Aerobatics, TimeBonus, TotalScore;
    int tempBaseScore, tempAerobatics, tempTimeBonus, tempTotalScore = 0;
    float tempScoreMultiplier = 0;
    [SerializeField] float ScoreMultiplier;
    [SerializeField] int Rating;
    [SerializeField] bool isLevelComplete;

    [SerializeField] int LevelID;

    [SerializeField] TextMeshProUGUI Completion;
    [SerializeField] Animator Canvas;
    [SerializeField] TextMeshProUGUI BaseScoreText, AerobaticsText, TimeBonusText, ScoreMultiplierText, TotalScoreText;
    [SerializeField] GameObject NewRecordDisplay;
 
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Level1HighScore", 0);
        TotalScore = (int)((BaseScore + TimeBonus + Aerobatics) * ScoreMultiplier);
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
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if(tempBaseScore >= BaseScore)
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
        TimeBonusText.text = "<color=#aaaaaa>Time Bonus</color>\n<size=125>" + tempTimeBonus + "</size>";
        if (tempTimeBonus >= TimeBonus)
        {
            tempTimeBonus = TimeBonus;
            TimeBonusText.text = "<color=#aaaaaa>Time Bonus</color>\n<size=125>" + tempTimeBonus + "</size>";
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

        tempScoreMultiplier += (int)Mathf.Ceil((Time.deltaTime * ScoreMultiplier) / 1.2f);
        ScoreMultiplierText.text = "<color=#aaaaaa>Score Multiplier</color>\n<size=125>" + tempScoreMultiplier + "</size>";
        if (tempScoreMultiplier >= ScoreMultiplier)
        {
            tempScoreMultiplier = ScoreMultiplier;
            ScoreMultiplierText.text = "<color=#aaaaaa>Score Multiplier</color>\n<size=125>" + tempScoreMultiplier + "</size>";
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

        tempTotalScore += (int)Mathf.Ceil((Time.deltaTime * TotalScore) / 1.2f);
        TotalScoreText.text = $"total score\n<size=250>{tempTotalScore}</size>";
        if (tempTotalScore >= TotalScore)
        {
            tempTotalScore = TotalScore;
            TotalScoreText.text = $"total score\n<size=250>{tempTotalScore}</size>";
            if(TotalScore > PlayerPrefs.GetInt($"Level{LevelID}HighScore"))
            {
                PlayerPrefs.SetInt($"Level{LevelID}HighScore", TotalScore);
                NewRecordDisplay.gameObject.SetActive(true);
                TotalScoreText.text = $"<color=#000000>total score\n<size=250>{tempTotalScore}</size></color>";
            }
        }
        else
        {
            StartCoroutine(TotalScoreAnimation());
        }
    }
}
