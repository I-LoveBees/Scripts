using UnityEngine;
using UnityEngine.Events;
public class TimerBehavior : MonoBehaviour
{
    public float duration;
    public float currentTime;
    public UnityEvent onTimerEvent;
    public UnityEvent onZeroEvent;
    
    //timer that starts when called
    public void StartTimer()
    {
        currentTime = duration;
        InvokeRepeating("UpdateTimer", 1, 1);
    }
    //timer countdown
    public void UpdateTimer()
    {
        currentTime--;
        if (currentTime <= 0)
        {
            onZeroEvent.Invoke();
            
        }
        else
        {
            onTimerEvent.Invoke();
        }
    }
}
