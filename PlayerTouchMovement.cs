using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchMovement : MonoBehaviour
{
    public float forwardSpeed = 5f; // Adjust the forward speed as needed

    // Update is called once per frame
    void Update()
    {
        // Move forward by default
        Vector3 forwardMovement = Vector3.forward * (forwardSpeed * Time.deltaTime);
        transform.Translate(forwardMovement);

        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.y = 0;

            // Move based on touch input
            transform.position = touchPosition;
        }
    }
}
