using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new();

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    IEnumerator FollowPath(){
        foreach(Waypoint waypoint in path){

            // Vector2Int vec = StringToVector(waypoint.name) * 10;
            // transform.position = new Vector3Int(vec.x, 0, vec.y);

            transform.position = waypoint.transform.position;
            
            yield return new WaitForSeconds(1f);
        }

    }

    Vector2Int StringToVector(string vec){
        string noBraces = vec.Replace("(", "").Replace(")", "");
        string[] vecValues = noBraces.Split(",");

        int x = int.Parse(vecValues[0]);
        int y = int.Parse(vecValues[1]);

        return new Vector2Int(x,y);
    }


}
