using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetractBoarder : MonoBehaviour
{
    Animator anim;
    Animator pAnim, sAnim, cAnim, qAnim;

    Text Subtitle;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();

        pAnim = GameObject.Find("PlayButton").GetComponent<Animator>();
        sAnim = GameObject.Find("SettingButton").GetComponent<Animator>();
        cAnim = GameObject.Find("CreditsButton").GetComponent<Animator>();
        qAnim = GameObject.Find("QuitButton").GetComponent<Animator>();

        Subtitle = GameObject.Find("Subtitle").GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown((KeyCode)331))
        {
            Debug.Log("Menu.Back Button Clicked");
            anim.SetBool("IsExpanded", false);

            StartCoroutine(Reanimate(0.3333f));
        }
    }

    public void OnButtonDown()
    {
        Debug.Log("Menu.Back Button Clicked");
        anim.SetBool("IsExpanded", false);

        StartCoroutine(Reanimate(0.3333f));
    }

    IEnumerator Reanimate(float duration)
    {
        yield return new WaitForSeconds(duration);

        pAnim.enabled = true;
        pAnim.SetTrigger("Selected");

        sAnim.enabled = true;
        sAnim.SetTrigger("Selected");

        cAnim.enabled = true;
        cAnim.SetTrigger("Selected");

        qAnim.enabled = true;
        qAnim.SetTrigger("Selected");

        Subtitle.text = "[NULL]";
    }
}
