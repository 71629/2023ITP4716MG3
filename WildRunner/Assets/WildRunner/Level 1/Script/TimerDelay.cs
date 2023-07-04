using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This cs is use for disable the timer during in loading screen.
//The loading screen will hold in 3 second to help the computer loading textures.
//After 3 second it will enable the timer.

public class TimerDelay : MonoBehaviour
{
    [SerializeField]
    public GameObject Camera;
    public GameObject timerDisplay;
    public float timer = -3f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        timerDisplay.SetActive(false);
        Camera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 1)
        {
            timer += Time.deltaTime;
            if (timer >= 0)
            {
                timerDisplay.SetActive(true);
                Camera.SetActive(false);
            }
        }
    }
}