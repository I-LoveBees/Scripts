using System.Collections;
using UnityEngine;

public class EnemyMovePattern : MonoBehaviour
{
    public float speed; // Adjust this to control the speed of the enemy
    public float moveDistance; // Adjust this to control how far the enemy moves

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool movingRight = true;

    void Start()
    {
        startPosition = transform.position;
        targetPosition = startPosition + Vector3.right * moveDistance;
        
        // Start the movement coroutine
        StartCoroutine(MoveCoroutine());
    }

    IEnumerator MoveCoroutine()
    {
        while (true)
        {
            // Move the enemy
            if (movingRight)
            {
                transform.Translate(Vector3.right * (speed * Time.deltaTime));
                if (transform.position.x >= targetPosition.x)
                {
                    movingRight = false;
                }
            }
            else
            {
                transform.Translate(Vector3.left * (speed * Time.deltaTime));
                if (transform.position.x <= startPosition.x)
                {
                    movingRight = true;
                }
            }

            yield return null; // Wait for the next frame
        }
    }
}
