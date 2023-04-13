using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Put all controller exclusive image and buttons here
    //Image must be hidden when not using controller
    //Controller exclusive buttons must be deactivated when not using a controller
    [SerializeField] Image[] ControllerIndicators;
    [SerializeField] Button[] ControllerDedicatedButtons;
    [SerializeField] GameObject[] ControllerHints;

    GameObject LastSelectedGameObject;
    [SerializeField] GameObject FirstSelect;

    [SerializeField] Slider MasterVolume, MusicVolume, VoiceVolume, SFXVolume;
    [SerializeField] Text[] ValueDisplay;
    [SerializeField] Text VolumeReset;
    [SerializeField] GameObject VolumeResetProgress;

    public static bool VolumeResetInProgress;

    private void Start()
    {
        if (PlayerPrefs.GetInt("ControlDevice") == 1)
        {
            EventSystem.current.SetSelectedGameObject(FirstSelect);
        }
    }

    private void Update()
    {
        //Check and update controller dedicated functions every frame
        switch (PlayerPrefs.GetInt("ControlDevice"))
        {
            case 0:
                for(int i = 0; i < ControllerDedicatedButtons.Length; i++)
                {
                    ControllerDedicatedButtons[i].enabled = false;
                }
                for(int i = 0; i < ControllerIndicators.Length; i++)
                {
                    ControllerIndicators[i].enabled = false;
                }
                for (int i = 0; i < ControllerHints.Length; i++)
                {
                    ControllerHints[i].SetActive(false);
                }
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                break;

            case 1:
                for (int i = 0; i < ControllerDedicatedButtons.Length; i++)
                {
                    ControllerDedicatedButtons[i].enabled = true;
                }
                for (int i = 0; i < ControllerIndicators.Length; i++)
                {
                    ControllerIndicators[i].enabled = true;
                }
                for (int i = 0; i < ControllerHints.Length; i++)
                {
                    ControllerHints[i].SetActive(true);
                }
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                break;
        }

        if (EventSystem.current.currentSelectedGameObject != null)
        {
            LastSelectedGameObject = EventSystem.current.currentSelectedGameObject;
        }
        else
        {
            EventSystem.current.SetSelectedGameObject(LastSelectedGameObject);
        }
        UpdateMasterVolume();
        UpdateMusicVolume();
        UpdateVoiceVolume();
        UpdateSFXVolume();
    }

    private void UpdateMasterVolume()
    { 
        PlayerPrefs.SetFloat("MasterVolume", MasterVolume.value);
        MasterVolume.value = PlayerPrefs.GetFloat("MasterVolume");
        ValueDisplay[0].text = (PlayerPrefs.GetFloat("MasterVolume")).ToString("0%");
        if (PlayerPrefs.GetFloat("MasterVolume") == 0) 
        { 
            ValueDisplay[0].color = new Color(0.5f, 0.2f, 0.2f);
            ValueDisplay[0].text = "MUTE";
        }
        if(PlayerPrefs.GetFloat("MasterVolume") > 1)
        {
            ValueDisplay[0].color = new Color(0, 1, 1);
        }
        if (PlayerPrefs.GetFloat("MasterVolume") <= 1 && PlayerPrefs.GetFloat("MasterVolume") != 0)
        {
            ValueDisplay[0].color = new Color(1, 1, 1);
        }
    }

    private void UpdateMusicVolume()
    { 
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume.value);
        MusicVolume.value = PlayerPrefs.GetFloat("MusicVolume");
        ValueDisplay[1].text = (PlayerPrefs.GetFloat("MusicVolume") * PlayerPrefs.GetFloat("MasterVolume")).ToString("0%");
        if (PlayerPrefs.GetFloat("MusicVolume") * PlayerPrefs.GetFloat("MasterVolume") == 0)
        {
            ValueDisplay[1].color = new Color(0.5f, 0.2f, 0.2f);
            ValueDisplay[1].text = "MUTE";
        }
        if (PlayerPrefs.GetFloat("MusicVolume") * PlayerPrefs.GetFloat("MasterVolume") > 1)
        {
            ValueDisplay[1].color = new Color(0, 1, 1);
        }
        if (PlayerPrefs.GetFloat("MusicVolume") * PlayerPrefs.GetFloat("MasterVolume") <= 1 && PlayerPrefs.GetFloat("MusicVolume") * PlayerPrefs.GetFloat("MasterVolume") != 0)
        {
            ValueDisplay[1].color = new Color(1, 1, 1);
        }
    }

    private void UpdateVoiceVolume()
    { 
        PlayerPrefs.SetFloat("VoiceVolume", VoiceVolume.value);
        VoiceVolume.value = PlayerPrefs.GetFloat("VoiceVolume");
        ValueDisplay[2].text = (PlayerPrefs.GetFloat("VoiceVolume") * PlayerPrefs.GetFloat("MasterVolume")).ToString("0%");
        if (PlayerPrefs.GetFloat("VoiceVolume") * PlayerPrefs.GetFloat("MasterVolume") == 0)
        {
            ValueDisplay[2].color = new Color(0.5f, 0.2f, 0.2f);
            ValueDisplay[2].text = "MUTE";
        }
        if (PlayerPrefs.GetFloat("VoiceVolume") * PlayerPrefs.GetFloat("MasterVolume") > 1)
        {
            ValueDisplay[2].color = new Color(0, 1, 1);
        }
        if (PlayerPrefs.GetFloat("VoiceVolume") * PlayerPrefs.GetFloat("MasterVolume") <= 1 && PlayerPrefs.GetFloat("VoiceVolume") * PlayerPrefs.GetFloat("MasterVolume") != 0)
        {
            ValueDisplay[2].color = new Color(1, 1, 1);
        }
    }

    private void UpdateSFXVolume()
    { 
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume.value);
        SFXVolume.value = PlayerPrefs.GetFloat("SFXVolume");
        ValueDisplay[3].text = (PlayerPrefs.GetFloat("SFXVolume") * PlayerPrefs.GetFloat("MasterVolume")).ToString("0%");
        if (PlayerPrefs.GetFloat("SFXVolume") * PlayerPrefs.GetFloat("MasterVolume") == 0)
        {
            ValueDisplay[3].color = new Color(0.5f, 0.2f, 0.2f);
            ValueDisplay[3].text = "MUTE";
        }
        if (PlayerPrefs.GetFloat("SFXVolume") * PlayerPrefs.GetFloat("MasterVolume") > 1)
        {
            ValueDisplay[3].color = new Color(0, 1, 1);
        }
        if (PlayerPrefs.GetFloat("SFXVolume") * PlayerPrefs.GetFloat("MasterVolume") <= 1 && PlayerPrefs.GetFloat("SFXVolume") * PlayerPrefs.GetFloat("MasterVolume") != 0)
        {
            ValueDisplay[3].color = new Color(1, 1, 1);
        }
    }

    public void ResetVolume()
    {
        VolumeResetInProgress = true;
        StartCoroutine(VolumeChangeEffect());
    }

    IEnumerator VolumeChangeEffect()
    {
        yield return new WaitForEndOfFrame();

        if (MasterVolume.value == 1 && MusicVolume.value == 1 && VoiceVolume.value == 1 && SFXVolume.value == 1)
        {
            VolumeReset.text = "Reset to default";
            MasterVolume.interactable = true;
            MusicVolume.interactable = true;
            VoiceVolume.interactable = true;
            SFXVolume.interactable = true;
            VolumeResetProgress.GetComponent<Slider>().value = 0;
            VolumeResetProgress.SetActive(false);
            VolumeReset.GetComponentInParent<Button>().enabled = true;
            VolumeResetInProgress = false;
        }
        else
        {
            StartCoroutine(VolumeChangeEffect());
            VolumeReset.text = "Adjusting";
            MasterVolume.interactable = false;
            MusicVolume.interactable = false;
            VoiceVolume.interactable = false;
            SFXVolume.interactable = false;
            VolumeResetProgress.SetActive(true);
            VolumeReset.GetComponentInParent<Button>().enabled = false;
        }

        MasterVolume.value += (1 - MasterVolume.value) * Time.deltaTime * 5;
        MusicVolume.value += (1 - MusicVolume.value) * Time.deltaTime * 5;
        VoiceVolume.value += (1 - VoiceVolume.value) * Time.deltaTime * 5;
        SFXVolume.value += (1 - SFXVolume.value) * Time.deltaTime * 5;

        if(MasterVolume.value >= 0.999f && MasterVolume.value <= 1.005f) { MasterVolume.value = 1; }
        if(MusicVolume.value >= 0.999f && MusicVolume.value <= 1.005f) { MusicVolume.value = 1; }
        if(VoiceVolume.value >= 0.999f && VoiceVolume.value <= 1.005f) { VoiceVolume.value = 1; }
        if(SFXVolume.value >= 0.999f && SFXVolume.value <= 1.005f) { SFXVolume.value = 1; }

        VolumeResetProgress.GetComponent<Slider>().value += (1 - VolumeResetProgress.GetComponent<Slider>().value) * Time.deltaTime * 5;
    }

    public static void QuitGame() //Quit Game
    {
        Debug.Log("Program Ended.");
        Application.Quit();
    } 
    
    public static void QuitGame(string errorMessage) //Throw Error
    {
        throw new System.Exception(errorMessage);
    }

    public static void EraseAllData(bool enable)
    {
        if (enable) { PlayerPrefs.DeleteAll(); }
        else { Debug.LogWarning("Operation Blocked: GameManager.EraseAllData()"); }
        SceneManager.LoadScene("Disclaimer");
    }
}
