using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < 499; i++)
        {

            if(Input.GetKeyDown((UnityEngine.KeyCode)i))
            {
                Debug.Log((KeyCode)i);
            }
        }
    }
}
