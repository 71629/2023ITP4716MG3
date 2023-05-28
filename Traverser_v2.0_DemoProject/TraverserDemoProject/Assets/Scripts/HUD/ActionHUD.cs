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

    public void EnableActionHUD(int actionType, string ActionName, string ControlName)
    {
        Debug.Log(actionType);

        gameObject.transform.GetChild(actionType).gameObject.SetActive(true);
        gameObject.transform.GetChild(actionType).GetComponentInChildren<Text>().text = ActionName;
        gameObject.transform.GetChild(actionType).GetComponent<Transform>().GetChild(0).GetComponent<Transform>().GetChild(0).GetComponent<Text>().text = ControlName;
    }

    public void DisableActionHUD(int actionType)
    {
        gameObject.transform.GetChild(actionType).gameObject.SetActive(false);
        gameObject.transform.GetChild(actionType).GetComponentInChildren<Text>().text = null;
        gameObject.transform.GetChild(actionType).GetComponent<Transform>().GetChild(0).GetComponent<Transform>().GetChild(0).GetComponent<Text>().text = null;
    }
}
