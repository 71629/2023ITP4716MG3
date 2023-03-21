using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class QuitOnClick : MonoBehaviour
{
    [SerializeField]
    Object original;

    public void OnButtonDown()
    {
        Debug.Log("Quit Button Clicked");
        Instantiate(original, GameObject.Find("Canvas").GetComponent<Transform>());
    }
}
