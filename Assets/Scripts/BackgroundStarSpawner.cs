using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStarSpawner : MonoBehaviour
{
    public float spawnRate = 10f;
    Vector3 whereToSpawn;
    float nextToSpawn = 0.0f;
    float randX;

    public GameObject backgroundStar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextToSpawn)
        {
            nextToSpawn = Time.time + spawnRate;
            randX = Random.Range(-11f, 11f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(backgroundStar, whereToSpawn, Quaternion.identity);
        }
    }
}
