using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

[ExecuteInEditMode]
public class CoordinateLabel : MonoBehaviour
{
    Vector2Int coords = new Vector2Int();

    void Awake() {
        DisplayCoordinates();
        ChangeParentName();

    }

    void Update()
    {
        DisplayCoordinates();
        ChangeParentName();
    }

    private void DisplayCoordinates()
    {
        float parentXPos = transform.parent.position.x;
        float parentZPos = transform.parent.position.z;

        float editorSnapX = UnityEditor.EditorSnapSettings.move.x;
        float editorSnapZ = UnityEditor.EditorSnapSettings.move.z;

        coords.x = Mathf.RoundToInt(parentXPos / editorSnapX);
        coords.y = Mathf.RoundToInt(parentZPos / editorSnapZ);
        GetComponent<TextMeshPro>().text = coords.ToString();

    }

    private void ChangeParentName()
    {
        transform.parent.name = coords.ToString();
    }
}
