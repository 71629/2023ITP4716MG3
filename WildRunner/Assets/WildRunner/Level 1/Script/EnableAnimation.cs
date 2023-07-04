using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAnimation : MonoBehaviour
{
    [SerializeField] GameObject Check5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Check5 == null)
        {
            GetComponent<Animator>().enabled = true;
        }
    }
}
