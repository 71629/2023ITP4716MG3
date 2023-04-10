using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ConfirmResetDataDialog : Dialog
{
    //Override parent functions
    protected override void InitDialog()
    {
        _title = "Erase All Data";
        _description = "You are about to erase the following items:\n-Progress\n-Settings\n-Profile\nAre you absolutely sure you want to proceed? Once erased, this action cannot be reverted.";
        _button1 = "Erase";
        _button2 = "Cancel";

        _isCritical = true;
        EventSystem.current.SetSelectedGameObject(null);
    }

    public override void OnButton1Down()
    {
        Debug.LogWarning("Erase all data");
        Close(1);
        GameManager.EraseAllData(false);
    }

    public override void OnButton2Down()
    {
        Debug.Log("Cancel reset");
        Close(2);
    }
}
