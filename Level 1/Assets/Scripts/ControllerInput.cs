using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ControllerInput : MonoBehaviour
{
    [SerializeField] Object Disconnection;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("ControlDevice") == 1)
        {
            GameObject.Find("EventSystem").GetComponent<EventSystem>().firstSelectedGameObject = GameObject.Find("PlayButton");
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 340; i <= 359; i++)
        {
            if(Input.GetKeyDown((UnityEngine.KeyCode)i))
            {
                Debug.Log((KeyCode)i);
            }
        }
        if (Input.GetAxis("XRI_DPad_Horizontal") >= 0.5f) { Debug.Log("R-DPad Pressed"); }
        if (Input.GetAxis("XRI_DPad_Horizontal") <= -0.5f) { Debug.Log("L-DPad Pressed"); }
        if (Input.GetAxis("XRI_DPad_Vertical") >= 0.5f) { Debug.Log("U-DPad Pressed"); }
        if (Input.GetAxis("XRI_DPad_Vertical") <= -0.5f) { Debug.Log("D-DPad Pressed"); }
    }

    void DisconnectDialog()
    {
        Debug.LogWarning("Controller Disconnected");
        GameObject dialog = Instantiate(Disconnection, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
        dialog.AddComponent<DisconnectionDialog>();
    }
}
