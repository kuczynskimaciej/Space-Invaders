using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStarSpawn : MonoBehaviour
{
    public float spawnRate = 10f;
    float randX;
    float nextToSpawn = 0.0f;
    Vector2 whereToSpawn;

    public GameObject smallStar;

    void Update()
    {
        if (Time.time > nextToSpawn)
        {
            nextToSpawn = Time.time + spawnRate;
            randX = Random.Range(-11f, 11f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(smallStar, whereToSpawn, Quaternion.identity);
        }
    }
}
