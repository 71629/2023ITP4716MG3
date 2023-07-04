using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    [SerializeField]Animator anim, Canvas;
    [SerializeField]AudioSource clickPlayButtonSound;

    public void OnButtonDown()
    {
        clickPlayButtonSound.Play();
        anim.SetTrigger("Highlighted");
        Canvas.SetTrigger("Play");
        Debug.Log("Play Button Clicked.");
    }
}
