using UnityEngine;

public class ColorMatchBehavior : MatchingBehavior
{
    public ColorIdDataList colorIdDataListObj;

    private void Awake()
    {
        idObj = colorIdDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.color = newColor.value;
    }
}
