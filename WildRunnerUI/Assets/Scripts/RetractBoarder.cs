using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetractBoarder : MonoBehaviour
{
    Animator anim;
    Animator pAnim, sAnim, cAnim, qAnim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();

        pAnim = GameObject.Find("PlayButton").GetComponent<Animator>();
        sAnim = GameObject.Find("SettingButton").GetComponent<Animator>();
        cAnim = GameObject.Find("CreditsButton").GetComponent<Animator>();
        qAnim = GameObject.Find("QuitButton").GetComponent<Animator>();
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
        sAnim.enabled = true;
        cAnim.enabled = true;
        qAnim.enabled = true;
    }
}
