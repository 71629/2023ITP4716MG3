using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateControlDevice : MonoBehaviour
{
    [SerializeField] Button b0, b1;
    [SerializeField] Text t0, t1;

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

    public void UseKM()
    {
        t0.color = new Color(1, 1, 1);
        t1.color = new Color(0.35f, 0.35f, 0.35f);
        PlayerPrefs.SetInt("ControlDevice", 0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void UseController()
    {
        t1.color = new Color(1, 1, 1);
        t0.color = new Color(0.35f, 0.35f, 0.35f);
        PlayerPrefs.SetInt("ControlDevice", 1);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
