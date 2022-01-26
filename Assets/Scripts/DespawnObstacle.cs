using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnObstacle : MonoBehaviour
{
    public GameObject obstacle;

    // Update is called once per frame
    void Update()
    {
        if (obstacle.transform.position.z < -65f ) {
            Destroy(obstacle);
        }        
    }
}
