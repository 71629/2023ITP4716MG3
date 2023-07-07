using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreen : MonoBehaviour
{
    public GameObject DisableController;
    public GameObject CameraHidden;
    public double delay = 3f;
    float timer = 0f;
    // Update is called once per frame
    void Start()
    {
        CameraHidden.SetActive(true);
    }

    void Update()
    {
        if(timer < delay)
        {
            DelayFunction();
        }
    }
    void DelayFunction()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            DisableController.SetActive(true);
            CameraHidden.SetActive(false);
            Destroy(gameObject); //Wait 3 second and destroy loading screen

        } else
        {
            DisableController.SetActive(false);
        }
    }
}
