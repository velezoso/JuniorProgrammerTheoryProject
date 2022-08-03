using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : ThreeDShape
{
    float radio, height;

    private void Awake()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        radio = meshRenderer.bounds.size.x;
        height = meshRenderer.bounds.size.z;
    }

    protected override float GetArea()
    {
        return 2 * Mathf.PI * radio * radio + 2 * Mathf.PI * radio * height;
    }

    protected override string GetName()
    {
        return "Cylinder";
    }

    protected override float GetVolume()
    {
        return Mathf.PI * radio * radio * height;
    }
}
