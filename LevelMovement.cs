using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    public float speed; // forward speed

    // Update is called once per frame
    void Update()
    {
        // Move backwards by default (moves the level foreward)
        Vector3 forwardMovement = -Vector3.forward * (speed * Time.deltaTime);
        transform.Translate(forwardMovement);
    }
}
