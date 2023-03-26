using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitDialog : Dialog
{
    //Override parent functions
    protected override void InitDialog()
    {
        _title = "Quit WildRunner";
        _description = "Are you sure you want to quit WildRunner?";
        _button1 = "Confirm";
        _button2 = "Cancel";

        _isCritical = true;
    }

    public override void OnButton1Down()
    {
        Debug.LogWarning("Quitting Game");
        Close(1);
    }

    public override void OnButton2Down()
    {
        Debug.Log("Cancel quit");
        Close(2);
    }

    //Additional features below
}
