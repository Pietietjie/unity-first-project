using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody obstacleRigidBody;

    void Update()
    {
        obstacleRigidBody.AddForce(0, 0, -500 * Time.deltaTime);        
    }

}
