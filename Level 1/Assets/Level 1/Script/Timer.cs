using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TMP_Text timerDisplay;
    public float timer = -0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if(timer >= 0)
        {
            timerDisplay.text = timer.ToString("f1");
        }
       
    }
}
