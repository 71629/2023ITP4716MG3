using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StuckEscape : MonoBehaviour
{
    // * Objects containing neccessary information
    [SerializeField] GameObject StuckEscapePrompt;

    // * Action to activate escape
    InputAction Action;

    private void Update()
    {

        // * If the Backquote key is released, hide the prompt and reset slider value
        if (Keyboard.current.backquoteKey.wasReleasedThisFrame)
        {
            // * Reset slider value
            StuckEscapePrompt.GetComponentInChildren<Slider>().value = 0;
            StuckEscapePrompt.SetActive(false);
        }

        // * If the Backquote key is held, increase slider value
        if (Keyboard.current.backquoteKey.isPressed)
        {
            StuckEscapePrompt.SetActive(true);
            StuckEscapePrompt.GetComponentInChildren<Slider>().value += 0.01f;
        }
    }
}
