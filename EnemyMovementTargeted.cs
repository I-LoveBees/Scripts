using UnityEngine;

public class EnemyMovementTargeted : MonoBehaviour
{
    public float speed; 
    private Transform target; // Reference to the player's transform
    private bool _istargetNotNull;

    void Start()
    {
        _istargetNotNull = target != null;
        // Find the player GameObject by tag
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (_istargetNotNull)
        {
            // Calculate the direction towards the player
            Vector3 direction = target.position - transform.position;

            // Normalize the direction vector
            direction.Normalize();

            // Move the enemy towards the player
            transform.Translate(direction * (speed * Time.deltaTime));
        }
    }
}
