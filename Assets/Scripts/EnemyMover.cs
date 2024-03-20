using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<GameObject> path = new();
    [SerializeField][Range(0f,5f)] float speed = .2f;

    void Start()
    {
        transform.position = path[0].transform.position;
        transform.LookAt(path[1].transform.position);
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath(){
        foreach(GameObject waypoint in path){
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float percentageMove = 0f;

            transform.LookAt(waypoint.transform.position);

            while(percentageMove <= 1f){
                percentageMove+=Time.deltaTime*speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, percentageMove);
                yield return new WaitForEndOfFrame();
            }

        }
    }



}
