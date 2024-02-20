using UnityEngine;

public class ColorIdBehavior : IDContainerBehavior
{
    public ColorIdDataList colorIdDataListObj;

    private void Awake()
    {
        idObj = colorIdDataListObj.currentColor;
    }
}
