using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

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
    }

    private void UpdateMusicVolume()
    { 
        PlayerPrefs.SetFloat("MusicVolume", MusicVolume.value);
    }

    private void UpdateVoiceVolume()
    { 
        PlayerPrefs.SetFloat("VoiceVolume", VoiceVolume.value);
    }

    private void UpdateSFXVolume()
    { 
        PlayerPrefs.SetFloat("SFXVolume", SFXVolume.value);
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
}
