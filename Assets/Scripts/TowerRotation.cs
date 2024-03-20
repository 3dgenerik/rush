using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRotation : MonoBehaviour
{
    EnemyMover target;

    void Start()
    {
        target = FindObjectOfType<EnemyMover>(); 
    }

    void Update()
    {
        AimWeapon();
        
    }

    void AimWeapon(){
        transform.LookAt(target.transform);
        
    }

    float Distance(){
        return Vector3.Distance(transform.position, target.transform.position);
    }
}
