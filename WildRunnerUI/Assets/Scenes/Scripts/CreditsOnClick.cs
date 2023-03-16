using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsOnClick : MonoBehaviour
{
    Animator anim;

    private void Start()
    {
        anim = GameObject.FindWithTag("Canvas").GetComponent<Animator>();
    }

    public void OnButtonDown()
    {
        Debug.Log("Credits Button Clicked");
        anim.SetBool("IsExpanded", !anim.GetBool("IsExpanded"));
    }
}
