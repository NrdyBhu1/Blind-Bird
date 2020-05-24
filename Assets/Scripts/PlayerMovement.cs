using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    #region Variables
    public Rigidbody2D rb;
    Vector2 position;
    public float speed;
    public float maxY;
    public float[] arr;
    public float minY;
    private float tmeBtwMvmnt = 1f;
    private float strtTmeBtwMvmnt = 2f;
    #endregion
    void FixedUpdate()
    {
        MoveToRandomPosition();
        rb.MovePosition(rb.position + position * speed * Time.fixedDeltaTime);
    }
    void MoveToRandomPosition(){
        if (tmeBtwMvmnt <= 0){
            float rand = Random.Range(minY, maxY);
            if (position.y > minY && position.y < maxY){
                position.y += rand;
            }
            tmeBtwMvmnt = strtTmeBtwMvmnt;
        }else{
            tmeBtwMvmnt -= Time.deltaTime;
        }
    }
}
