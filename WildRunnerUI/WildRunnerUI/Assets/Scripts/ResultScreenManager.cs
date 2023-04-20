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

    [SerializeField] TextMeshProUGUI Completion;
    [SerializeField] Animator Canvas;
    [SerializeField] TextMeshProUGUI BaseScoreText, AerobaticsText, TimeBonusText, ScoreMultiplierText, TotalScoreText;

    // Start is called before the first frame update
    void Start()
    {
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
    public void StartCounting()
    {
        StartCoroutine(BaseScoreAnimation());
    }

    IEnumerator BaseScoreAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempBaseScore += (int)Mathf.Ceil((Time.deltaTime * BaseScore) / 0.6f);
        BaseScoreText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempBaseScore + "</size>";
        if(tempBaseScore >= BaseScore)
        {
            tempBaseScore = BaseScore;
            StartCoroutine(AerobaticsAnimation());
        }
    }

    IEnumerator AerobaticsAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempAerobatics += (int)Mathf.Ceil((Time.deltaTime * Aerobatics) / 0.6f);
        AerobaticsText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempAerobatics + "</size>";
        if (tempAerobatics >= Aerobatics)
        {
            tempAerobatics = Aerobatics;
            StartCoroutine(TimeBonusAnimation());
        }
    }

    IEnumerator TimeBonusAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempTimeBonus += (int)Mathf.Ceil((Time.deltaTime * TimeBonus) / 0.6f);
        TimeBonusText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempTimeBonus + "</size>";
        if (tempTimeBonus >= TimeBonus)
        {
            tempTimeBonus = TimeBonus;
            StartCoroutine(ScoreMultiplierAnimation());
        }
    }

    IEnumerator ScoreMultiplierAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempScoreMultiplier += (int)Mathf.Ceil((Time.deltaTime * ScoreMultiplier) / 0.6f);
        ScoreMultiplierText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempScoreMultiplier + "</size>";
        if (tempScoreMultiplier >= ScoreMultiplier)
        {
            tempScoreMultiplier = ScoreMultiplier;
            StartCoroutine(TotalScoreAnimation());
        }
    }

    IEnumerator TotalScoreAnimation()
    {
        yield return new WaitForEndOfFrame();

        tempTotalScore += (int)Mathf.Ceil((Time.deltaTime * TotalScore) / 0.6f);
        TotalScoreText.text = "<color=#aaaaaa>Base Score</color>\n<size=125>" + tempTotalScore + "</size>";
        if (tempTotalScore >= TotalScore)
        {
            tempTotalScore = TotalScore;
        }
    }
}
