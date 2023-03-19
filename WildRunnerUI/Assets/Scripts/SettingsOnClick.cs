using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsOnClick : MonoBehaviour
{
    Animator anim;
    Animator pAnim, sAnim, cAnim, qAnim;
    private void Start()
    {
        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();

        pAnim = GameObject.Find("PlayButton").GetComponent<Animator>();
        sAnim = GameObject.Find("SettingButton").GetComponent<Animator>();
        cAnim = GameObject.Find("CreditsButton").GetComponent<Animator>();
        qAnim = GameObject.Find("QuitButton").GetComponent<Animator>();
    }
    public void OnButtonDown()
    {
        Debug.Log("Settings Button Clicked");
        anim.SetBool("IsExpanded", true);

        pAnim.enabled = false;
        sAnim.enabled = false;
        cAnim.enabled = false;
        qAnim.enabled = false;
        Debug.Log("Animators Killed");
    }
}
