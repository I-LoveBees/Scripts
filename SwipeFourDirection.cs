using UnityEngine;
using UnityEngine.InputSystem;

public class SwipeFourDirection : MonoBehaviour
{
    private PlayerControls controls;
    
    [SerializeField] private float minSwipeMagnitude = 10f;
    [SerializeField] private float moveSpeed = 5f; // Speed of movement
    private Vector3 moveDirection = Vector3.zero; // Stores current movement direction

    void Start()
    {
        controls = new PlayerControls();
        controls.Player.Enable();

        controls.Player.Swipe.canceled += ProcessTouchComplete;
        controls.Player.Swipe.performed += ProcessSwipeDelta;
    }

    private void Update()
    {
        // Move continuously in the current direction
        transform.position += moveDirection * (moveSpeed * Time.deltaTime);
    }

    private void ProcessSwipeDelta(InputAction.CallbackContext context)
    {
        Vector2 swipeInput = context.ReadValue<Vector2>();
        
        if (swipeInput.magnitude < minSwipeMagnitude) return; // Ignore weak swipes

        // Determine new movement direction
        if (Mathf.Abs(swipeInput.x) > Mathf.Abs(swipeInput.y)) 
        {
            // Horizontal swipe
            moveDirection = new Vector3(swipeInput.x > 0 ? 1 : -1, 0, 0);
        }
        else 
        {
            // Vertical swipe
            moveDirection = new Vector3(0, 0, swipeInput.y > 0 ? 1 : -1);
        }
    }

    private void ProcessTouchComplete(InputAction.CallbackContext context)
    {
        Debug.Log("Swipe detected, moving in direction: " + moveDirection);
    }
}