using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ThreeDShape
{
    private float radio;

    private void Awake()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        radio = meshRenderer.bounds.size.x;
    }

    protected override float GetArea()
    {
        return 4 * Mathf.PI * radio * radio;
    }

    protected override string GetName()
    {
        return "Sphere";
    }

    protected override float GetVolume()
    {
        return 4 / 3 * Mathf.PI * radio * radio * radio;
    }
}
