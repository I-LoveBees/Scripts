using UnityEngine;

public class MatchingBehavior : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>();
        if(tempID == null) // If the other object does not have an IDContainerBehavior component, stop running
            return;
            
        var otherID = tempID.idObj;
        if (idObj == otherID)
        {
            Debug.Log("Matching ID");
        }
    }
}
