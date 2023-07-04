using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisconnectionDialog : Dialog
{
    //Override parent functions
    protected override void InitDialog()
    {
        _title = "Controller Disconnected";
        _description = "Your controller has disconnected. Please re-connect your controller to continue, or restart the game without controller to switch to mouse & keyboard.";
        _button1 = "";
        _button2 = "";

        _isCritical = false;
    }

    //Additional features below
}
