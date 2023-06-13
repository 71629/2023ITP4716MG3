using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delaying : MonoBehaviour
{
    public GameObject Loading;
    public float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < 3)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Destroy(Loading);
        }
        
    }
}
