using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ResetProgress : MonoBehaviour, IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] GameObject slider;
    [SerializeField] GameObject original;

    bool isPressed;

    private void Update()
    {
        if( slider.GetComponent<Slider>().value >= 1 )
        {
            slider.GetComponent<Slider>().value = 0;
            slider.SetActive(false);
            GameObject dialog = Instantiate(original, GameObject.Find("Canvas").GetComponent<Transform>()) as GameObject;
            dialog.AddComponent<ConfirmResetDataDialog>();
        }
    }

    public void OnUpdateSelected(BaseEventData data)
    {
        if ( isPressed )
        {
            slider.GetComponent<Slider>().value += 0.01f * Time.deltaTime;
        }
    }

    public void OnPointerDown(PointerEventData data)
    {
        slider.SetActive(true);
        isPressed = true;
    }

    public void OnPointerUp(PointerEventData data)
    {
        slider.GetComponent<Slider>().value = 0;
        slider.SetActive(false);
        isPressed = false; 
    }
}
