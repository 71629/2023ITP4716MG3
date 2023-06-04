using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public double delay = 0.5;
    float timer;
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
            Destroy(gameObject);
        }
    }
}
