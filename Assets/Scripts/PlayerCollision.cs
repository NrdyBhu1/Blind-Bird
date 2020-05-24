using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject killSound;
    public PlayerMovement movement;
    void OnCollisionEnter2D(Collision2D body){
        if (body.collider.CompareTag("Poles")){
                Kill();
        }
    }
    void Kill(){
        movement.enabled = false;
        Instantiate(killSound, transform.position, Quaternion.identity);
        FindObjectOfType<GameManager>().GameOver();
    }
}
