using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallStar : MonoBehaviour
{
    private Transform smallStar;
    public float minSpeed;
    public float maxSpeed;
    float speed;

    void Start()
    {
        smallStar = GetComponent<Transform>();
    }

    void Update()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        smallStar.position += Vector3.down * speed * 0.1f;
        smallStar.transform.Rotate(0f, 0f, 7f, Space.Self);
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
