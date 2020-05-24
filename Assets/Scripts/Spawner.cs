using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public GameObject monsterPrefab;
    public GameObject[] prefabs;
    public float strtTmeBtwSpawn;
    float tmeBtwSpwn = .05f;

    void Update(){
        SpawnPoles(transform.position);
    }
    void SpawnPoles(Vector3 position){
        if (tmeBtwSpwn <= 0){
            int rand = Random.Range(0, prefabs.Length);
            Instantiate(prefabs[rand], position, Quaternion.identity);
            tmeBtwSpwn = strtTmeBtwSpawn;
            strtTmeBtwSpawn -= 0.025f;
        }else{
            tmeBtwSpwn -= Time.deltaTime;
        }
    }
}
