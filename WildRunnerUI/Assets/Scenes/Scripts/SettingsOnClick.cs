using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsOnClick : MonoBehaviour
{
    Animator anim;
    public void OnButtonDown()
    {
        anim = GameObject.FindWithTag("LBorder").GetComponent<Animator>();
        Debug.Log("Settings Button Clicked");
    }
}
