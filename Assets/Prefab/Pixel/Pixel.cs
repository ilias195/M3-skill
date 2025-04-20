using UnityEngine;

public class Pixel : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color color = new Color(1, 0, 0, 1);

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer == null)
        {
            Debug.LogError("Geen SpriteRenderer gevonden op dit GameObject!");
        }
    }

    void Update()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.color = color;
        }
    }
}
