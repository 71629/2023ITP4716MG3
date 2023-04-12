using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpdateVolume : MonoBehaviour
{
    [SerializeField] GameObject Selection;
    [SerializeField] GameObject Category;

    private void LateUpdate()
    {
        if(EventSystem.current.currentSelectedGameObject == this.gameObject && Input.GetKeyDown((KeyCode)332))
        {
            EventSystem.current.SetSelectedGameObject(Selection);
        }
        if(EventSystem.current.currentSelectedGameObject == Selection)
        {
            if (Input.GetKeyDown((KeyCode)331)) { EventSystem.current.SetSelectedGameObject(this.gameObject); }
            Selection.GetComponent<Slider>().value += Input.GetAxis("Horizontal") * 0.01f;
        }
        if (EventSystem.current.currentSelectedGameObject == this.gameObject)
        {
            if(Input.GetKeyDown((KeyCode)331)) { EventSystem.current.SetSelectedGameObject(Category); }
        }
    }
}
