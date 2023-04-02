using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    [SerializeField]Animator anim;

    public void OnButtonDown()
    {
        anim.SetTrigger("Highlighted");
        Debug.Log("Play Button Clicked.");
    }
}
