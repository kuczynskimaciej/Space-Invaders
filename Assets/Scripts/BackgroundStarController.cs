using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundStarController : MonoBehaviour
{
    public float speed;
    private Transform backGroundStar;
    // Start is called before the first frame update
    void Start()
    {
        backGroundStar = GetComponent<Transform>();  
    }

    // Update is called once per frame
    void Update()
    {
        backGroundStar.position += Vector3.down * speed;

        if(backGroundStar.position.y < -7.5f)
        {
            Destroy(backGroundStar.gameObject);
        }
    }
}
