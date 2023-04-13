using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UpdateVolume : MonoBehaviour
{
    [SerializeField] GameObject Selection;
    [SerializeField] GameObject Category;

    private void Update()
    {
        if(EventSystem.current.currentSelectedGameObject == this.gameObject && Input.GetKeyDown((KeyCode)332))
        {
            StartCoroutine(SelectNext());
        }
        if(EventSystem.current.currentSelectedGameObject == Selection)
        {
            if (Input.GetKeyDown((KeyCode)331)) { StartCoroutine(SelectPrev(this.gameObject)); }
            Selection.GetComponent<Slider>().value += Input.GetAxis("Horizontal") * 0.01f;
        }
        if (EventSystem.current.currentSelectedGameObject == this.gameObject)
        {
            if(Input.GetKeyDown((KeyCode)331)) { StartCoroutine(SelectPrev(Category)); }
        }
        if (Input.GetKeyDown((KeyCode)330) && GameManager.VolumeResetInProgress != true)
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().ResetVolume();
        }
    }

    IEnumerator SelectNext()
    {
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(Selection);
    }

    IEnumerator SelectPrev(GameObject Selection)
    {
        yield return new WaitForEndOfFrame();
        EventSystem.current.SetSelectedGameObject(Selection);
    }
}
