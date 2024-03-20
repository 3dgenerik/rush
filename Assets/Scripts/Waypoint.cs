using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] bool isPlacable;
    [SerializeField] GameObject tower;


    private void OnMouseDown() {
        if(isPlacable){
            Instantiate(tower, transform.position, Quaternion.identity);
            isPlacable = false;
        }
    }

}
