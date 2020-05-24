using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 position;
    void Update()
    {
        position = transform.position;
        if (player.position.x > transform.position.x + 5){
            position.x = player.position.x + 10f;
            position.z = player.position.z - 3f;
        }
        transform.position = position;
    }
}
