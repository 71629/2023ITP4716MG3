using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayOnClick : MonoBehaviour
{
    [SerializeField]Animator anim;
    [SerializeField]AudioSource clickPlayButtonSound;
    [SerializeField] bool OnClick = false;
    [SerializeField] float timer = 0;

    public void OnButtonDown()
    {
        clickPlayButtonSound.Play();
        anim.SetTrigger("Highlighted");
        Debug.Log("Play Button Clicked.");
        OnClick = true;
        
    }
    void Update()
    {   if(OnClick == true && timer >0.2)
        {
            SceneManager.LoadScene("LevelSelect");
        } 
        else
        {
            timer += Time.deltaTime;
        }
        
    }
}
