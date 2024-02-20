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
        num = Random.Range(0, colorIdList.Count);
        currentColor = colorIdList[num];
        Debug.Log(num);
    }
}
