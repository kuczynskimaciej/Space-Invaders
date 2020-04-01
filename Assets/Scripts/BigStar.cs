using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStar : MonoBehaviour
{
    private Transform bigStar;
    public float speed;

    void Start()
    {
        bigStar = GetComponent<Transform>();
    }

    void Update()
    {
        bigStar.position += Vector3.down * speed * 0.1f;

        if (bigStar.position.y < -7.5f)
        {
            Destroy(bigStar.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            GameOver.isPlayerDead = true;
        }
    }
}
