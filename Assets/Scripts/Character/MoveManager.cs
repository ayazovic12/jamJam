using UnityEngine;
using UnityEngine.InputSystem;

public class MoveManager : MonoBehaviour
{
    private Animator animator;
    private InputManager inputManager;
    private CharacterController characterController;
    [SerializeField] private float walkSpeed = 5f;
    [SerializeField] private float runSpeed = 9f;
    [SerializeField] private float mouseSensitivity = 0.2f;
    
    void Awake()
    {
        inputManager = GetComponent<InputManager>();
        characterController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }
    void Start()
    {
        //
    }

    public Vector2 movement;
    void Update()
    {
        Move();
        movement = inputManager.Move;
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
        float speed;

        if (move != Vector3.zero)
        {
            speed = inputManager.Run ? runSpeed : walkSpeed;
        }
        else
        {
            speed = 0;
        }
        
        characterController.SimpleMove(moveDirection * speed);
        animator.SetFloat("VerticalMoveSpeed", inputManager.Move.y * speed);
        animator.SetFloat("HorizontalMoveSpeed", inputManager.Move.x * speed);
    }
}