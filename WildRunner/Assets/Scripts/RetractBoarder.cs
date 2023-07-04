using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RetractBoarder : MonoBehaviour
{
    Animator anim;
    Animator pAnim, sAnim, cAnim, qAnim;

    Text Subtitle;

    [SerializeField] GameObject[] IgnoreBack;
    [SerializeField] GameObject SettingsItems;
    [SerializeField] GameObject SelectOnRetract;
    [SerializeField] Animator SettingsMenu;

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
        for(int i = 0; i < IgnoreBack.Length; i++)
        {
            if(EventSystem.current.currentSelectedGameObject == IgnoreBack[i]) { return; }
        }
        if (Input.GetKeyDown((KeyCode)331))
        {
            Debug.Log("Menu.Back Button Clicked");
            anim.SetBool("IsExpanded", false);
            EventSystem.current.SetSelectedGameObject(null);

            StartCoroutine(Reanimate(0.3333f));
        }
    }

    public void OnButtonDown()
    {
        Debug.Log("Menu.Back Button Clicked");
        anim.SetBool("IsExpanded", false);
        SettingsMenu.SetBool("isOpened", false);


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

        SettingsItems.SetActive(false);
        SettingsMenu.SetBool("isOpened", false);
        EventSystem.current.SetSelectedGameObject(SelectOnRetract);
    }
}
