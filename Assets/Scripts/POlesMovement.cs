using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POlesMovement : MonoBehaviour
{
    public float speed = 10f;
    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-25, transform.position.y, transform.position.z), speed * Time.deltaTime);
        if (transform.position.x <= -25f){
            FindObjectOfType<GameManager>().AddScore();
            Destroy(gameObject);
        }
    }
}
