using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class QuitOnClick : MonoBehaviour
{
    [SerializeField]
    Object original;
    [SerializeField] Animator anim;

    public void OnButtonDown()
    {
        anim.SetTrigger("Normal");
        Debug.Log("Quit Button Clicked");
        GameObject dialog = Instantiate(original, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
        dialog.AddComponent<QuitDialog>();
    }
}
