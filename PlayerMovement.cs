using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

   // private PlayerControls controls;



    private void MovePlayer(float horizontalInput)
    {
        Vector3 moveDirection = new Vector3(horizontalInput, 0f, 0f);
        transform.Translate(moveDirection * (moveSpeed * Time.deltaTime));
    }
    
    public float moveSpeed = 5f;        // Player movement speed
    public float jumpForce = 7f;        // Force applied when jumping
    public float gravity = -9.81f;      // Gravity applied to the character
    
    private CharacterController controller;  // The character controller component
    private Vector3 velocity;               // Current velocity of the character

    // Awake is called when the script instance is initialized
    private void Awake()
    {
        // Get the CharacterController component attached to this GameObject
        controller = GetComponent<CharacterController>();
        //controls = new PlayerControls(); 
        //controls.Enable();
    }

    // Update is called once per frame
    private void Update()
    {
        // wasd movement

        var moveH = Input.GetAxis("Horizontal");
        var moveDirection = new Vector3(moveH, 0f, 1f) * moveSpeed;

        // Button press movement
      //  MovePlayer(controls.Player.MoveLeft.ReadValue<float>() - controls.Player.MoveRight.ReadValue<float>());
        moveH = 0f;

        // Check if the "LeftButton" is pressed
        if (Input.GetButton("LeftButton"))
        {
            moveH = -1f;
        }
        // Check if the "RightButton" is pressed
        else if (Input.GetButton("RightButton"))
        {
            moveH = 1f;
        }

        // Apply gravity
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            velocity.y = 0;
        }

        // Apply movement and gravity
        var move = moveDirection + velocity;
        controller.Move(move * Time.deltaTime);

        // Rotate player to face direction of movement
        if (moveDirection != Vector3.zero)
        {
            transform.forward = moveDirection;
        }
    }
}
