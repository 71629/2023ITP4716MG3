using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PassDisclaimer : MonoBehaviour
{
    [SerializeField] bool[] Bypass = new bool[2];
    TMP_Text ins;
    Animator anim;
    float time = 3.3333f;

    // Start is called before the first frame update
    void Start()
    {
        ins = GameObject.Find("instruction").GetComponent<TextMeshProUGUI>();
        anim = GameObject.Find("Canvas").GetComponent<Animator>();
        if (Bypass[0]) { time = 0; }
        if (Bypass[1]) { Exit(); }
    }

    // Update is called once per frame
    private void Update()
    {
        time -= Time.deltaTime;
        if (time < 3)
        {
            ins.fontSize = 40;
            if(time > 0)
            {
                ins.text = "3";
                if (time < 2)
                {
                    ins.text = "2";
                }
                if (time < 1)
                {
                    ins.text = "1";
                }
            }
            else
            {
                ins.fontSize = 20;
                ins.text = "Press any key to continue...";
            }
        }
        if(Input.anyKeyDown && time <= 0)
        {
            anim.SetTrigger("Exit");
        }
    }

    public void Exit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
