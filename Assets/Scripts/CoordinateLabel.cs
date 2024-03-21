using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

[ExecuteInEditMode]
public class CoordinateLabel : MonoBehaviour
{
    Vector2Int coords = new();

    void Awake() {
        DisplayCoordinates();
        ChangeParentName();

    }


    void Update()
    {
        DisplayCoordinates();
        ChangeParentName();
        ChangeLabelColor();
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

    private void ChangeLabelColor(){
        bool isPlacable = GetComponentInParent<Waypoint>().IsPlacable;

        if(isPlacable){
            GetComponent<TextMeshPro>().color = new Color(0f,1f,0f);
        }else{
            GetComponent<TextMeshPro>().color = new Color(1f,0f,0f);
        }
    }

    private void ChangeParentName()
    {
        transform.parent.name = coords.ToString();
    }
}
