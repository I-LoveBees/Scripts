using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MatchingBehavior : IDContainerBehavior
{
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempID = other.GetComponent<IDContainerBehavior>();
        if(tempID == null) // If the other object does not have an IDContainerBehavior component, stop running
            yield break; //similar to return, but for IEnumerator
            
        var otherID = tempID.idObj;
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
            yield return new WaitForSeconds(0.5f);
            noMatchDelayedEvent.Invoke(); //for ending the game ?
        }
    }
}
