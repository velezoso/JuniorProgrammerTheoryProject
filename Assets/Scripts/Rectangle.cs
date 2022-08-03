using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : TwoDShape
{
    private float width;
    private float height;

    private void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        width = spriteRenderer.sprite.bounds.size.x;
        height = spriteRenderer.sprite.bounds.size.y;
    }
    protected override float GetArea()
    {
        return width * height;
    }

    protected override string GetName()
    {
        return "Rectangle";
    }

    protected override float GetLength()
    {
        return 2 * width + 2 * height;
    }
}