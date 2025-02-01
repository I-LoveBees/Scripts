using UnityEngine;
using UnityEngine.InputSystem;

public class SwipeTest : MonoBehaviour
{
    private PlayerControls controls;
    
    [SerializeField] private float minSwipeMagnitude = 10f;
    private Vector2 swipeDirection;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controls = new PlayerControls();
        controls.Player.Enable();

        // Get the specific InputAction for swiping (e.g., "Swipe" action)
        controls.Player.Swipe.canceled += ProcessTouchComplete;
        controls.Player.Swipe.performed += ProcessSwipeDelta;
    }

    private void ProcessSwipeDelta(InputAction.CallbackContext context)
    {
        swipeDirection = context.ReadValue<Vector2>();
    }
    
    private void ProcessTouchComplete(InputAction.CallbackContext context)
    {
        //check if magnitude is high enough
        Debug.Log("Touch complete");
        if (Mathf.Abs(swipeDirection.magnitude) < minSwipeMagnitude) return;
        Debug.Log("Swipe detected");
        
        var position = Vector3.zero;
        
        //check horizontal direction
        if(swipeDirection.x > 0)
        {
            position.x = 1;
        }
        else if(swipeDirection.x < 0)
        {
            position.x = -1;
        }
        
        //check vertical direction
        if(swipeDirection.y > 0)
        {
            position.z = 1;
        }
        else if(swipeDirection.y < 0)
        {
            position.z = -1;
        }
        //apply changes to obj
        transform.position = position;
    }
}
