using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu]
public class ColorIdDataList : ScriptableObject
{
    public List<ColorID> colorIdList;
    public ColorID currentColor;
    
    private int num;

    public void SetCurrentColorRandomly()
    {
        num = Random.Range(0, colorIdList.Count); //randomizes between 0 and the count of colorIdList
        currentColor = colorIdList[num]; //sets currentColor to the colorID at the randomized index
        Debug.Log(num);
    }
}
