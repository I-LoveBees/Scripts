using UnityEngine;

public class PlayerTouchMovement : MonoBehaviour
{
    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position); //convert touch position to world space
            touchPosition.y = 0; //should constrain the player to the xz plane

            // Move based on touch input
            transform.position = touchPosition;
        }
    }
}
