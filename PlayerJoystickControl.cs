using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystickControl : MonoBehaviour
{
    public float moveSpeed;        // Player movement speed
    
    private Rigidbody controller;  // The character controller component
    private Vector3 velocity;               // Current velocity of the character

    public Joystick joystick;
    
    // Awake is called when the script instance is initialized
    private void Awake()
    {
        // Get the CharacterController component attached to this GameObject
        controller = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        // wasd movement

        var moveH = joystick.Horizontal;
        var moveV = joystick.Vertical;
        var moveDirection =  new Vector3(moveH, 0f, moveV) * moveSpeed;

        //if shift button is pressed, run at twice the speed move speed is set to
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection = new Vector3(moveH, 0f, moveV) * (moveSpeed * 2);
        }

        // Apply movement and gravity do i need this?
        var move = moveDirection + velocity;
        controller.velocity = move;
        
    }

}
