using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ActionHUD : MonoBehaviour
{
    [SerializeField] Sprite KeyboardKeySprite;
    [SerializeField] Sprite[] GamepadKeys;

    public enum KeyboardKeys
    {
        Q,
        E,
        shift,
        Space,
    }

    public enum ActionType
    {
        HighAction = 0,
        DownAction = 1,
        LeftAction = 2,
        RightAction = 3,
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleActionHUD(ActionType actionType, string ActionName, string ControlName)
    {
        GameObject.Find(actionType.ToString()).SetActive(true);
        GameObject.Find(actionType.ToString()).GetComponentInChildren<Text>().text = ActionName;
        GameObject.Find(actionType.ToString()).GetComponent<Transform>().GetChild(1).GetComponent<Text>().text = ControlName;
    }
}
