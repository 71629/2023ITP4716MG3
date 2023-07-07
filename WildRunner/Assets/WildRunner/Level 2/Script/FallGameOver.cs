using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallGameOver : MonoBehaviour
{
    [SerializeField] GameObject GameOverScreen, HiddenCamera;
    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            HiddenCamera.SetActive(true);
            GameOverScreen.SetActive(true);
            Debug.Log("GameOver");
        }
    }
}