using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StuckEscape : MonoBehaviour
{
    [Header("Stuck Escape Prompt")]
    [SerializeField] GameObject StuckEscapePrompt;

    [Header("Player Transform")]
    [SerializeField] GameObject Agent;
    string PlayerState;
    PlayerInformation playerInformation;

    struct PlayerInformation
    {
        float _TimeStamp;
        Vector3 _Position;

        public Vector3 Position
        {
            get { return _Position; }
            set { Position = value; }
        }

        public float TimeStamp
        {
            get { return _TimeStamp; }
            set { TimeStamp = value; }
        }
    }

    private void Start()
    {
        // * Resets the slider value, in case if it's not 0 somehow
        ResetSECBuffer();

        PlayerState = Agent.GetComponent<Traverser.TraverserLocomotionAbility>().GetLocomotionState().ToString();
        playerInformation = new PlayerInformation();
    }

    private void Update()
    {
        // * Check if the player wants to use SEC
        CheckCancel();
        CheckSECCall();
    }

    private void CheckSECCall()
    {
        // * If the Backquote key is held, call SECBuffer function
        if (Keyboard.current.backquoteKey.isPressed)
        {
            SECBuffer();
        }
    }

    private void CheckCancel()
    {
        // * If the Backquote key is released, hide the prompt and reset slider value
        if (Keyboard.current.backquoteKey.wasReleasedThisFrame)
        {
            CancelSEC();
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
        SECGuard();



        ResetSECBuffer();
    }

    private void SECGuard()
    {
        if (PlayerState == "Moving")
        {
            // TODO: Prompt SEC not required
            return;
        }
        Agent.GetComponent<Transform>().GetComponentInParent<Transform>().position = playerInformation.Position;
    }

    // * Update the player's information
    private void UpdatePlayerInformation()
    {
        // * Update PlayerTransform
        playerInformation.Position = Agent.GetComponent<Transform>().GetComponentInParent<Transform>().position;
    }
}
