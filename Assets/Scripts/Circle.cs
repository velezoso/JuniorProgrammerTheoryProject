using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : TwoDShape
{
    float radio;

    private void Awake()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        radio = spriteRenderer.sprite.bounds.size.x;
    }

    protected override float GetArea()
    {
        return Mathf.PI * radio * radio;
    }

    protected override string GetName()
    {
        return "Circle";
    }

    protected override float GetLength()
    {
        return 2 * Mathf.PI * radio;
    }
}
