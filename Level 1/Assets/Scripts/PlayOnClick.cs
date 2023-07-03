using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    [SerializeField]Animator anim, Canvas;

    public void OnButtonDown()
    {
        anim.SetTrigger("Highlighted");
        Canvas.SetTrigger("Play");
        Debug.Log("Play Button Clicked.");
    }
}
