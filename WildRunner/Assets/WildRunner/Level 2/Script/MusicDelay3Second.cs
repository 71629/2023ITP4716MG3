using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicDelay3Second : MonoBehaviour
{
    [SerializeField] public float timer = 0;
    [SerializeField] public GameObject bgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer <= 3 )
        {
            timer += Time.deltaTime;
            bgm.SetActive(false);
        } else
        {
            bgm.SetActive(true);
        }
    }
}
