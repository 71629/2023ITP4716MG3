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
    Animator animator;
    bool ProgressBar;

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
        animator = gameObject.GetComponent<Animator>();
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
        if (Keyboard.current.backquoteKey.wasPressedThisFrame)
        {
            animator.SetTrigger("Start");
        }
    }

    private void CheckCancel()
    {
        // * If the Backquote key is released, hide the prompt and reset slider value
        if (Keyboard.current.backquoteKey.wasReleasedThisFrame)
        {
            ProgressBar = true;
            animator.SetTrigger("End");
            Invoke("CancelSEC", 0.5f);
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
        GetComponentInChildren<Transform>().GetChild(0).GetComponentInChildren<Text>().text = "HOLD TO START SEC";
    }

    private void SECBuffer()
    {
        if (ProgressBar)
        {
            animator.enabled = true;
            StuckEscapePrompt.GetComponentInChildren<Slider>().value += Time.deltaTime * 0.5f;
        }

        ExecuteSEC(StuckEscapePrompt.GetComponentInChildren<Slider>().value);
    }

    private void ExecuteSEC(float value)
    {
        // * Checks is the value is full
        if (value >= 1)
        {
            ProgressBar = false;
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
        if (PlayerState == "Moving" && !Agent.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Landing"))
        {
            HaltSEC();
            return;
        }
        Agent.GetComponent<Transform>().GetComponentInParent<Transform>().position = playerInformation.Position;
    }

    private void HaltSEC()
    {
        animator.SetTrigger("Halt");
        GetComponentInChildren<Transform>().GetChild(0).GetComponentInChildren<Text>().text = "SEC NOT REQUIRED";
        StuckEscapePrompt.GetComponentInChildren<Slider>().value = 0.9999f;
    }

    // * Update the player's information
    private void UpdatePlayerInformation()
    {
        // * Update PlayerTransform
        if (PlayerState == "Moving" && !Agent.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Landing"))
        {
            playerInformation.Position = Agent.GetComponent<Transform>().GetComponentInParent<Transform>().position;
        }
    }
}
