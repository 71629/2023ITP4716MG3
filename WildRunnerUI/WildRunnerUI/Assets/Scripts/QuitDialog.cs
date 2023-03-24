using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitDialog : Dialog
{
    public override void InitDialog()
    {
        _title = "Steve Job";
        _description = "";
        _button1 = "yes";
        _button2 = "no";

        _isCritical = true;

        Button1.onClick.AddListener(delegate { DebugYes(); });
        Button2.onClick.AddListener(delegate { DebugYes(); });
    }

    void DebugYes()
    {
        Debug.Log("Yes");
    }
}
