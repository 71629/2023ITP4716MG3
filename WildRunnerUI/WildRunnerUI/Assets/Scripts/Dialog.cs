using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    Animator anim;

    [SerializeField] protected string _title; //Title text
    [SerializeField] protected string _description; //Description text
    [SerializeField] protected string _button1; //Left button text, usually for a POSITIVE response
    [SerializeField] protected string _button2; //Right button text, usually for a NEGATIVE response
    [SerializeField] protected bool _isCritical; //Makes Button1 red

    [SerializeField]
    private Text Title, Description, ButtonText1, ButtonText2;

    [SerializeField]
    protected Button Button1, Button2;

    // Start is called before the first frame update
    void Start()
    {
        ////Reference to GameObjects
        Title = GameObject.Find("Title").GetComponent<Text>();
        Description = GameObject.Find("Description").GetComponent<Text>();
        ButtonText1 = GameObject.Find("Button1").GetComponentInChildren<Text>();
        ButtonText2 = GameObject.Find("Button2").GetComponentInChildren<Text>();

        Button1 = GameObject.Find("Button1").GetComponent<Button>();
        Button2 = GameObject.Find("Button2").GetComponent<Button>();

        anim = this.GetComponent<Animator>();

        //Replace empty text fields
        if (_title == "") { _title = "Title"; }
        if (_description == "") { _description = "Description"; }
        if (_button1 == "") { _button1 = "Button 1"; }
        if (_button2 == "") { _button2 = "Button 2"; }

        InitDialog();

        //Apply texts
        Title.text = _title;
        Description.text = _description;
        ButtonText1.text = _button1;
        ButtonText2.text = _button2;

        //Apply colors
        if (_isCritical) { ButtonText1.color = new Color(1, 0.15f, 0.15f, 1); }
    }

    public void OnButton1Down()
    {
        //Initial Action
        Close();

        //Follow-up Actions
    }

    public void OnButton2Down()
    {
        //Initial Action
        Close();

        //Follow-up Actions
    }

    void Close()
    {
        anim.SetTrigger("Quit");
    }

    public void DialogEnd()
    {
        GameObject.Destroy(this.gameObject);
    }

    public virtual void InitDialog()
    {
        _title = "Runner";
        //_description = "";
        //_button1 = "yes";
        //_button2 = "no";

        //_isCritical = true;

        //Button1.onClick.AddListener(()=>Debug.Log("Yes"));
        //Button2.onClick.AddListener(() => Debug.Log("No"));
    }
}
