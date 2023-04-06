using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.EventSystems;

public class UpdateControlDevice : MonoBehaviour
{
    [SerializeField] Button b0, b1;
    [SerializeField] Text t0, t1;
    [SerializeField] GameObject SelectOnController;
    [SerializeField] GameObject Settings;

    private void Start()
    {
        switch (PlayerPrefs.GetInt("ControlDevice"))
        {
            case 0:
                UseKM();
                break;
            case 1:
                UseController();
                break;
            default:
                throw new PlayerPrefsException("Corrupted settings found.");
        }
    }

    private void Update()
    {
        
    }

    public void Toggle()
    {
        switch (PlayerPrefs.GetInt("ControlDevice"))
        {
            case 0:
                PlayerPrefs.SetInt("ControlDevice", 1);
                Debug.Log("You're now using a controller!");
                break;
            case 1:
                PlayerPrefs.SetInt("ControlDevice", 0);
                Debug.Log("You're now using keyboard and mouse!");
                break;
        }
        Start();
    }

    public void UseKM()
    {
        t0.color = new Color(0.8f, 0.8f, 1);
        t1.color = new Color(0.35f, 0.35f, 0.35f);
        PlayerPrefs.SetInt("ControlDevice", 0);
    }

    public void UseController()
    {
        t1.color = new Color(0.8f, 0.8f, 1);
        t0.color = new Color(0.35f, 0.35f, 0.35f);
        PlayerPrefs.SetInt("ControlDevice", 1);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(SelectOnController);
    }
}
