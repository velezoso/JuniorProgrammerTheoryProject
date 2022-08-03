using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DescriptionPopUpManager : MonoBehaviour
{

    [SerializeField] TMP_Text _name, info;

    private void Awake()
    {
        var gameObjects = GameObject.FindGameObjectsWithTag("Shape");
        foreach (var gameObject in gameObjects)
        {
            var shape = gameObject.GetComponent<BaseShape>();
            shape.OnShapeSelected += DisplayShapeDescription;
        }
    }

    private void DisplayShapeDescription(BaseShape shape)
    {
        _name.text = shape.Name;
        info.text = shape.Info;
    }

    private void OnDestroy()
    {
        var gameObjects = GameObject.FindGameObjectsWithTag("Shape");
        foreach (var gameObject in gameObjects)
        {
            var shape = gameObject.GetComponent<BaseShape>();
            shape.OnShapeSelected -= DisplayShapeDescription;
        }
    }
}