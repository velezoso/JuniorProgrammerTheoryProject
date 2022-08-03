using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class ThreeDShape : BaseShape
{
    // ABSTRACTION
    // POLYMORPHISM
    protected override string GetInfo()
    {
        return $"Area: {string.Format("{0:.##}", GetArea())} m\xB2 \n Volume: {string.Format("{0:.##}", GetVolume())} m\xB3";
    }

    // POLYMORPHISM
    protected abstract float GetArea();
    protected abstract float GetVolume();
}