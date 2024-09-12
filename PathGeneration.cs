using UnityEngine;

public class PathGeneration : MonoBehaviour
{
    
    
    //copy group and put it at the end of the path
    public void CopyGroup()
    {
        //get the last group
        var lastGroup = transform.GetChild(transform.childCount - 1);
        //create a new group
        var newGroup = Instantiate(lastGroup, transform);
        //move the new group to the end of the path
        newGroup.position = lastGroup.position + Vector3.right * 10;
    }
}

