using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    public float speed;

    void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        // Destroy the bullet after 2 seconds
        Destroy(gameObject, 2);
    }
}
