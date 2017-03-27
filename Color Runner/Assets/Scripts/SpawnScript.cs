using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;

    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        Instantiate(obj)[UnityEngine.Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", UnityEngine.Random.Range(spawnMin, spawnMax));
    }
}