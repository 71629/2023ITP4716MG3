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

        GameObject.Find("QuitButton").GetComponent<Button>().interactable = false;
    }

    public override void OnButton1Down()
    {
        Debug.LogWarning("Quitting Game");
        Close(1);
        GameManager.QuitGame();
        GameObject.Find("QuitButton").GetComponent<Button>().interactable = true;
    }

    public override void OnButton2Down()
    {
        Debug.Log("Cancel quit");
        Close(2);
        GameObject.Find("QuitButton").GetComponent<Button>().interactable = true;
        GameObject.Find("QuitButton").GetComponent<Animator>().SetTrigger("Highlighted");
    }

    //Additional features below
}
