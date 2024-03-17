using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;

public class InputManager : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;

    public bool isPaused = false;

    public Vector2 Move { get; private set; }
    public Vector2 Look { get; private set; }
    public bool Run { get; private set; }
    public bool Attack1 { get; private set; }
    public bool Attack2 { get; private set; }
    public bool Pause { get; private set; }

    private InputActionMap currentMap;
    private InputAction moveAction;
    private InputAction lookAction;
    private InputAction runAction;
    private InputAction attack1Action;
    private InputAction attack2Action;
    private InputAction pauseAction;

    private void Awake()
    {
        HideCursor();
        currentMap = playerInput.currentActionMap;
        moveAction = currentMap.FindAction("Move");
        lookAction = currentMap.FindAction("Look");
        runAction = currentMap.FindAction("Run");
        attack1Action = currentMap.FindAction("Attack1");
        attack2Action = currentMap.FindAction("Attack2");
        pauseAction = currentMap.FindAction("Pause");

        moveAction.performed += onMove;
        lookAction.performed += onLook;
        runAction.performed += onRun;
        attack1Action.performed += onAttack1;
        attack2Action.performed += onAttack2;
        pauseAction.performed += onPause;

        moveAction.canceled += onMove;
        lookAction.canceled += onLook;
        runAction.canceled += onRun;
        attack1Action.canceled += onAttack1;
        attack2Action.canceled += onAttack2;
    }

    private void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void onMove(InputAction.CallbackContext context)
    {
        Move = context.ReadValue<Vector2>();
    }
    private void onLook(InputAction.CallbackContext context)
    {
        Look = context.ReadValue<Vector2>();
    }
    private void onRun(InputAction.CallbackContext context)
    {
        Run = context.ReadValueAsButton();
    }

    private void onAttack1(InputAction.CallbackContext context)
    {
        Attack1 = context.ReadValueAsButton();
    }
    private void onAttack2(InputAction.CallbackContext context)
    {
        Attack2 = context.ReadValueAsButton();
    }

    private void onPause(InputAction.CallbackContext context)
    {
        Pause = context.ReadValueAsButton();
        if (context.performed)
        {
            // Toggle the boolean value
            isPaused = !isPaused;
            Debug.Log("Boolean value toggled: " + isPaused);
        }
    }

    private void OnEnable()
    {
        currentMap.Enable();
    }
    private void OnDisable()
    {
        currentMap.Disable();
    }
}