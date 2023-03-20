using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitOnClick : MonoBehaviour
{
    public void OnButtonDown()
    {
        Debug.Log("Quit Button Clicked");
        Application.Quit();
    }
}
