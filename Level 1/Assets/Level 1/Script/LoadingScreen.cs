using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public double delay = 3f;
    float timer = 0f;
    // Update is called once per frame
    void Update()
    {
        DelayFunction();
    }
    void DelayFunction()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            Destroy(gameObject); //Wait 3 second and destroy loading screen
        }
    }
}
