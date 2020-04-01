using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStarSpawner : MonoBehaviour
{
    public float spawnRate = 10f;
    float randX;
    float nextToSpawn = 0.0f;
    Vector2 whereToSpawn;

    public GameObject bigStar;

    void Update()
    {
        if (Time.time > nextToSpawn)
        {
            nextToSpawn = Time.time + spawnRate;
            randX = Random.Range(-11f, 11f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(bigStar, whereToSpawn, Quaternion.identity);
        }
    }
}