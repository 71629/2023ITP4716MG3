using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SettingsOnClick : MonoBehaviour
{
    [SerializeField] Button[] settings;
    Animator anim;
    Animator pAnim, sAnim, cAnim, qAnim;
    [SerializeField] Button Select;
    [SerializeField] GameObject SettingsItems;

    Text Subtitle;

    private void Start()
    {
        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();

        pAnim = GameObject.Find("PlayButton").GetComponent<Animator>();
        sAnim = GameObject.Find("SettingButton").GetComponent<Animator>();
        cAnim = GameObject.Find("CreditsButton").GetComponent<Animator>();
        qAnim = GameObject.Find("QuitButton").GetComponent<Animator>();

        Subtitle = GameObject.Find("Subtitle").GetComponent<Text>();
    }

    public void OnButtonDown()
    {
        Debug.Log("Settings Button Clicked");
        anim.SetBool("IsExpanded", true);
        SettingsItems.SetActive(true);

        pAnim.enabled = false;
        sAnim.enabled = false;
        cAnim.enabled = false;
        qAnim.enabled = false;
        Debug.Log("Animators Killed");

        Subtitle.text = "Settings";

        for (int i = 0; i < settings.Length; i++) { settings[i].enabled = true; }

        Select.Select();
    }
}
