using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShape : MonoBehaviour
{
    // ENCAPSULATION
    public string Info { get { return GetInfo(); } }
    public string Name { get { return GetName(); } }

    public event Action<BaseShape> OnShapeSelected;

    protected abstract string GetInfo();

    protected abstract string GetName();

    private void OnMouseDown()
    {
        OnShapeSelected?.Invoke(this);
    }
}