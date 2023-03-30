using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] TMP_Text title;
    [SerializeField] Animator Menu;
    public void Resume() 
    {
        StopAllCoroutines();
        Menu.SetTrigger("Resume");
        title.text = "RESUME";
    }
    public void Retry() 
    {
        StopAllCoroutines();
        Menu.SetTrigger("Retry");
        StartCoroutine(TimeWait());
        title.text = "CONFIRM RETRY?";
    }
    public void Restart() { }
    public void Retire() 
    {
        StopAllCoroutines();
        Menu.SetTrigger("Retire");
        StartCoroutine(TimeWait());
        title.text = "CONFIRM RETIRE?";
    }
    public void Quit() { }
    IEnumerator TimeWait()
    {
        yield return new WaitForSeconds(2.5f);
        Expire();
    }
    public void Expire()
    { 
        Menu.SetTrigger("Expire");
        StopAllCoroutines();
        title.text = "PAUSED";
    }
}
