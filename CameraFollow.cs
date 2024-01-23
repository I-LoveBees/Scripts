using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //ai
    public Transform target;          // Player's transform to follow
    public Vector3 offset = new Vector3(0f, 5f, 10f);  // Camera offset from the player
    public float smoothSpeed = 0.125f; // Smoothing factor for camera movement
    public bool lockRotationX = false;
    public bool lockRotationY = true;
    public bool lockRotationZ = false;

    private void LateUpdate()
    {
        // Calculate the desired camera position based on the target's position and offset
        Vector3 desiredPosition = target.position + offset;

        // Smoothly move the camera towards the desired position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        // Make the camera look at the target
        transform.LookAt(target);

        // Apply rotation constraints
        Vector3 eulerAngles = transform.eulerAngles;
        if (lockRotationX) eulerAngles.x = 0;
        if (lockRotationY) eulerAngles.y = 0;
        if (lockRotationZ) eulerAngles.z = 0;
        transform.eulerAngles = eulerAngles;
    }
}
