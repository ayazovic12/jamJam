using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoveManager : MonoBehaviour
{
    private InputManager inputManager;
    private CharacterController characterController;
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 9f;
    [SerializeField] private float mouseSensitivity = 0.2f;
    
    void Awake()
    {
        inputManager = GetComponent<InputManager>();
        characterController = GetComponent<CharacterController>();
    }
    void Start()
    {
        //
    }

    void Update()
    {
        Move();
    }

    void FixedUpdate()
    {
        //
    }

    void LateUpdate()
    {
        Look();
    }

    void Look()
    {
        if (inputManager.isPaused) return;
        var mouseAxisX = inputManager.Look.x * mouseSensitivity;
        transform.Rotate(0, mouseAxisX, 0);
    }

    private void Move()
    {
        var move = new Vector3(inputManager.Move.x, 0, inputManager.Move.y);
        var moveDirection = transform.TransformDirection(move);
        var speed = inputManager.Run ? runSpeed : walkSpeed;
        characterController.SimpleMove(moveDirection * speed);
    }
}