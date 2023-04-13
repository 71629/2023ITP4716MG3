using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SettingsMenu : MonoBehaviour
{
    //Stores a numbers of GameObjects of MenuItem and individual items in the category
    [SerializeField] GameObject[] MenuItem;
    [SerializeField] GameObject[] CategoryItem;
    [SerializeField] GameObject[] FirstItemInCategory; //Corresponding Indicator or MenuItem

    //Stores a single GameObject recently selected
    GameObject LastSelectedCategory; 

    //Stores a single GameObject that indicates the currently active category
    int ActiveCategory;

    private void Start()
    {
        //set true if need to check pairing
        if (false)
        {
            if (MenuItem.Length != CategoryItem.Length)
            {
                GameManager.QuitGame("Non-matching array length of Category list and Item list.");
            }
            for (int i = 0; i < MenuItem.Length; i++)
            {
                if (MenuItem[i].ToString() != CategoryItem[i].ToString())
                {
                    Debug.LogError("INVALID pair " + MenuItem[i] + " and " + CategoryItem[i] + ".");
                    GameManager.QuitGame("Non-matching MenuItem and CategoryItem GameObjects.");
                }
                else
                {
                    Debug.Log(MenuItem[i].ToString() + " VALID pairing.");
                }
            }
        }
    }

    private void Update()
    {
        for(int i = 0; i < MenuItem.Length; i++)
        {
            if(EventSystem.current.currentSelectedGameObject == MenuItem[i] || LastSelectedCategory == MenuItem[i])
            {
                LastSelectedCategory = MenuItem[i];
                MenuItem[i].GetComponentInChildren<Text>().color = new Color(1, 1, 1);
                CategoryItem[i].SetActive(true);
                ActiveCategory = i;
            }
            else
            {
                MenuItem[i].GetComponentInChildren<Text>().color = new Color(0.6f, 0.6f, 0.6f);
                CategoryItem[i].SetActive(false);
            }
        }
        if (Input.GetKeyDown((KeyCode)332))
        {
            StartCoroutine(SelectNext());
        }
    }
    IEnumerator SelectNext()
    {
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(FirstItemInCategory[ActiveCategory]);
    }
}
