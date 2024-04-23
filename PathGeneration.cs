using UnityEngine;

public class PathGeneration : MonoBehaviour
{
    //create copy of ground and wall prefabs
    //put it in front of the previous ground and walls
    
    public GameObject groundPrefab, wallPrefab;
    public int pathLength;

    private void Start()
    {
        for (int i = 0; i < pathLength; i++)
        {
            Instantiate(groundPrefab, new Vector3(i, 0, 0), Quaternion.identity);
            Instantiate(wallPrefab, new Vector3(i, 1, 0), Quaternion.identity);
        }
    }
}

