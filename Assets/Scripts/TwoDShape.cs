using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public abstract class TwoDShape : BaseShape
{

    // ABSTRACTION
    // POLYMORPHISM
    protected override string GetInfo()
    {
        return $"Area: {string.Format("{0:.##}", GetArea())} m\xB2 \n Length: {string.Format("{0:.##}", GetLength())} m";
    }

    // POLYMORPHISM
    protected abstract float GetArea();
    protected abstract float GetLength();
}