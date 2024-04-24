using UnityEngine;

public class PathGeneration : MonoBehaviour
{
    public GameObject[] pathPieces;

    public Transform thresholdPoint;

    void Update()
    {
        if (transform.position.z < thresholdPoint.position.z)
        {
            //copy the path piece & move forward
            //Instantiate(pathPiece, new Vector3(0, 0, transform.position.z + 10), Quaternion.identity);
            //Instantiate(pathPieces, transform.position, transform.rotation);
            //transform.position += new Vector3(0, 0, 2.1f);

            //randomly select a path piece and generate it
            int randomIndex = Random.Range(0, pathPieces.Length);
            Instantiate(pathPieces[randomIndex], transform.position, transform.rotation);
            transform.position += new Vector3(0, 0, 2.1f);
        }
    }
}

