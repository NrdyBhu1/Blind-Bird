using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pole : MonoBehaviour
{
    void Start()
    {
        Color color = GetComponent<SpriteRenderer>().color;
        color.r = RandomColorValue();
        color.g = RandomColorValue();
        color.b = RandomColorValue();
        GetComponent<SpriteRenderer>().color = color;
    }
    float RandomColorValue(){
        float randomValue = Random.Range(1.000f, 0.000f);
        return randomValue;
    }
}
