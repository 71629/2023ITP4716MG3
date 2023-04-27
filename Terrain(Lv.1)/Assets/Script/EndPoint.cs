using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class EndPoint : ShowUI
{   
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";      
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EndPoint"))
        {
            showEndUI();
        }
    }

}
