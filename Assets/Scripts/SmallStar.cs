using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStar : MonoBehaviour
{
    private Transform smallStar;
    public float speed;

    void Start()
    {
        smallStar = GetComponent<Transform>();
    }

    void Update()
    {
        smallStar.position += Vector3.down * speed * 0.1f;

        if (smallStar.position.y < -7.5f)
        {
            Destroy(smallStar.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            GameOver.isPlayerDead = true;
        }
    }
}
