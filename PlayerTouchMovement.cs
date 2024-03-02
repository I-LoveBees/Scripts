using UnityEngine;

public class PlayerTouchMovement : MonoBehaviour
{
    public float minX, maxX, minZ, maxZ;
    
    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position); //convert touch position to world space
            touchPosition.y = 0; //should constrain the player to the xz plane

            // Constrain the player to the specified boundaries
            float x = Mathf.Clamp(transform.position.x, minX, maxX);
            float z = Mathf.Clamp(transform.position.z, minZ, maxZ);
            transform.position = new Vector3(x, 0, z);
            
            
            
            // Move based on touch input
            transform.position = touchPosition;            
            
        }
    }
}
