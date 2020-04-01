using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStarHealth : MonoBehaviour
{

    public float health = 2;

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
