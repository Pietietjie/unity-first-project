using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 2.5f, 2.5f);
    }

    void SpawnObstacle()
    {
        GameObject spawnedObstacle = Instantiate(obstacle);
        spawnedObstacle.transform.position = new Vector3(Random.Range(-2f, 2f), 1f, 0f);
    }
}
