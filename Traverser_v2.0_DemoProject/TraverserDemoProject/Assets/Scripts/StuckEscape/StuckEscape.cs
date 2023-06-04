using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StuckEscape : MonoBehaviour
{
    // * Objects containing neccessary information
    [SerializeField] GameObject StuckEscapePrompt;

    private void Update()
    {

        // * If the Backquote key is released, hide the prompt and reset slider value
        if (Keyboard.current.backquoteKey.wasReleasedThisFrame)
        {
            CancelSEC();
        }

        // * If the Backquote key is held, increase slider value
        if (Keyboard.current.backquoteKey.isPressed)
        {
            SECBuffer();
        }
    }

    private void CancelSEC()
    {
        ResetSECBuffer();
    }

    // * Reset slider value
    private void ResetSECBuffer()
    {
        StuckEscapePrompt.GetComponentInChildren<Slider>().value = 0;
        StuckEscapePrompt.SetActive(false);
    }

    private void SECBuffer()
    {
        StuckEscapePrompt.SetActive(true);
        StuckEscapePrompt.GetComponentInChildren<Slider>().value += Time.deltaTime * 0.5f;

        ExecuteSEC(StuckEscapePrompt.GetComponentInChildren<Slider>().value);
    }

    private void ExecuteSEC(float value)
    {
        // * Checks is the value is full
        if (value >= 1)
        {
            SEC();
        }
    }

    private void SEC()
    {
        ResetSECBuffer();
    }
}
