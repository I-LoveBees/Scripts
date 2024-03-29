using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public UnityEvent disableEvent;

    public void UpdateValue(int num)
    {
        value += num;
    }
    public void SetValue(int num)
    {
        value = num;
    }

    public void SetValue(IntData obj)
    {
        value = obj.value;
    }
    
    public void CompareValue(IntData obj)
    {
        if (value >= obj.value)
        {
            //if value is les than obj value, don't do anything
        }
        else
        {
            value = obj.value;
        }
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value.ToString();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
