using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
    
    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
        //gets information from the ColorID script
    }
    
    public void ChangeRendererColor(ColorIdDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
        //gets information from the ColorIdDataList script ?
    }
}
