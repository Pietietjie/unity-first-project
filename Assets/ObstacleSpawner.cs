using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;

    public List<Vector3[]> layoutPresets = new List<Vector3[]> {
        new Vector3[] {
            new Vector3(4, 1f, 0f),
            new Vector3(-4, 1f, 0f)
        },
        new Vector3[] {
            new Vector3(0, 1f, 0f),
            new Vector3(0, 1f, 0f),
            new Vector3(-4, 1f, 0f)
        }
    };

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, 3f);
    }

    void SpawnObstacle()
    {
        Vector3[] spawnLayout = layoutPresets.RandElement();
        for (int i = 0; i < spawnLayout.Length; i++) {
            GameObject spawnedObstacle = Instantiate(obstacle);
            spawnedObstacle.transform.position = spawnLayout[i];
        }
    }
}
