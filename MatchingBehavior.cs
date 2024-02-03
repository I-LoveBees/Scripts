using UnityEngine;
using UnityEngine.Events;

public class MatchingBehavior : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    private void OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>();
        if(tempID == null) // If the other object does not have an IDContainerBehavior component, stop running
            return;
            
        var otherID = tempID.idObj;
        
        if (idObj == otherID)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
