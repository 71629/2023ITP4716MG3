using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DemoChange : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
            SceneManager.LoadScene("Level1");
    }
}
