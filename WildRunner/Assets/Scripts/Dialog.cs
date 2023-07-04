using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    Animator anim;

    protected string _title; //Title text
    protected string _description; //Description text
    protected string _button1; //Left button text, usually for a POSITIVE response
    protected string _button2; //Right button text, usually for a NEGATIVE response
    protected bool _isCritical; //Makes Button1 red

    [SerializeField]
    private Text Title, Description, ButtonText1, ButtonText2;

    [SerializeField]
    protected Button Button1, Button2;

    private void Awake()
    {
        ////Reference to GameObjects
        Title = GameObject.Find("Title").GetComponent<Text>();
        Description = GameObject.Find("Description").GetComponent<Text>();
        ButtonText1 = GameObject.Find("Button1").GetComponentInChildren<Text>();
        ButtonText2 = GameObject.Find("Button2").GetComponentInChildren<Text>();

        Button1 = GameObject.Find("Button1").GetComponent<Button>();
        Button2 = GameObject.Find("Button2").GetComponent<Button>();

        anim = this.GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        InitDialog();

        //Apply texts
        Title.text = _title;
        Description.text = _description;
        ButtonText1.text = _button1;
        ButtonText2.text = _button2;

        //Apply color
        if (_isCritical) { ButtonText1.color = new Color(1, 0.15f, 0.15f, 1); }

        Button1.onClick.AddListener(() => OnButton1Down());
        Button2.onClick.AddListener(() => OnButton2Down());
    }

    //Force abort from frozen Dialog
    private void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) { Close("Abort Dialog"); } 
        if (Input.GetKeyDown((KeyCode)332)) { OnButton1Down(); }
        if (Input.GetKeyDown((KeyCode)331)) { OnButton2Down(); }
    }

    //Quit
    protected void Close() { anim.SetTrigger("Quit"); }

    //Debug
    protected void Close(int KeyNum)
    {
        Debug.Log("Button " + KeyNum + " in the dialog is pressed.");
        Close();
    }

    //Debug
    protected void Close(string ErrorMessage)
    {
        Debug.LogError(ErrorMessage);
        Close();
    }

    public void DialogEnd() { GameObject.Destroy(this.gameObject); } //Called by Animator

    protected virtual void InitDialog()
    {
        _title = "Title";
        _description = "No description.";
        _button1 = "Button 1";
        _button2 = "Button 2";

        _isCritical = false;
    }

    public virtual void OnButton1Down(){}
    public virtual void OnButton2Down(){}
}
