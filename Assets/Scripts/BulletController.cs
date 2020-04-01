using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Transform bullet;
    public float speed;

    void Start()
    {
        bullet = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        bullet.position += Vector3.up * speed;

        if (bullet.position.y >= 7)
            Destroy(bullet.gameObject);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
        else if (other.tag == "Base")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "SmallStar")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
        else if (other.tag == "BigStar")
        {
            GameObject BigStar = other.gameObject;
            BigStarHealth BigStarHealth = BigStar.GetComponent<BigStarHealth>();
            BigStarHealth.health -= 1f;
            Destroy(gameObject);
            PlayerScore.playerScore += 10;
        }
    }
}
