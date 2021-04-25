using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public Rigidbody2D player;
    Vector2 movement;
    public float speed;
    public float maxBoundX, minBoundX;
    public float maxBoundY, minBoundY;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }

    void FixedUpdate()
    {
        if (player.position.x < minBoundX && movement.x < 0)
            movement.x = 0;
        else if (player.position.x > maxBoundX && movement.x > 0)
            movement.x = 0;
        else if (player.position.y > maxBoundY && movement.y > 0)
            movement.y = 0;
        else if (player.position.y < minBoundY && movement.y < 0)
            movement.y = 0;

        player.MovePosition(player.position + movement * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameOver.isPlayerDead = true;
        }
    }
}
