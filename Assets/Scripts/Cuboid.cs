using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuboid : ThreeDShape
{
    float width, height, depth;
    private void Awake()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        width = meshRenderer.bounds.size.x;
        height = meshRenderer.bounds.size.y;
        depth = meshRenderer.bounds.size.z;
    }

    protected override float GetArea()
    {
        return 2 * width + 2 * height + 2 * depth;
    }

    protected override string GetName()
    {
        return "Cuboid";
    }

    protected override float GetVolume()
    {
        return width * height * depth;
    }
}
