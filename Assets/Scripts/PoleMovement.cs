using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleMovement : MonoBehaviour
{
    public float minY;
    public GameObject pushSound;
    private bool selected = false;
    private Vector2 mousePos;
    void Update(){
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (selected == true){
            transform.position = new Vector3(transform.position.x, mousePos.y, transform.position.z);
            Instantiate(pushSound, transform.position, Quaternion.identity, transform);
        }
        if (transform.position.y < minY){
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }
        if (Input.GetMouseButtonUp(0)){
            selected = false;
        }
    }
    void OnMouseOver(){
        if (Input.GetMouseButtonDown(0)){
            selected = true;
        }
    }
}
