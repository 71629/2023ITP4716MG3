using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SettingsOnClick : MonoBehaviour
{
    Animator anim;
    Animator pAnim, sAnim, cAnim, qAnim;
    [SerializeField] Animator SettingsMenu;

    Text Subtitle;

    [SerializeField] GameObject Settings;
    [SerializeField] GameObject FirstCategory;
    [SerializeField] AudioSource clickPlayButtonSound;

    private void Start()
    {
        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();

        pAnim = GameObject.Find("PlayButton").GetComponent<Animator>();
        sAnim = GameObject.Find("SettingButton").GetComponent<Animator>();
        cAnim = GameObject.Find("CreditsButton").GetComponent<Animator>();
        qAnim = GameObject.Find("QuitButton").GetComponent<Animator>();

        Subtitle = GameObject.Find("Subtitle").GetComponent<Text>();

        Debug.Log("Target Item: " + FirstCategory.ToString());
    }

    public void OnButtonDown()
    {
        clickPlayButtonSound.Play();
        Debug.Log("Settings Button Clicked");
        anim.SetBool("IsExpanded", true);

        pAnim.enabled = false;
        sAnim.enabled = false;
        cAnim.enabled = false;
        qAnim.enabled = false;
        Debug.Log("Animators Killed");

        Subtitle.text = "Settings";

        Settings.SetActive(true);
        SettingsMenu.SetBool("isOpened", true);
        EventSystem.current.SetSelectedGameObject(FirstCategory);
    }
}
