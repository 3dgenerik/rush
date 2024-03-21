using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        if(target){
            transform.LookAt(target.transform);
        }else{
            StartCoroutine(RotateBackCourutine());
            GetComponentInChildren<ParticleSystem>().Stop();
        }
    }

    IEnumerator RotateBackCourutine(){
        float percentageBulletMove = 0f;
        Quaternion startRotation = transform.rotation;

        while(percentageBulletMove <= .5f){
            percentageBulletMove += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(startRotation, Quaternion.identity, percentageBulletMove);
            yield return new WaitForEndOfFrame();
        }
    }

    float Distance(){
        return Vector3.Distance(transform.position, target.transform.position);
    }
}
