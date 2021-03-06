using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovePet : MonoBehaviour
{
    int moveX;
    int moveY;

    int[] speeds = {-1,1};

    Rigidbody2D rb;

    void Awake()
    {
        moveX = speeds[UnityEngine.Random.Range(0,2)];
        moveY = speeds[UnityEngine.Random.Range(0,2)];   
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(moveX,moveY);
    }

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(rb.velocity.x * Math.Abs(transform.localScale.x), transform.localScale.y);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "SideWall")
            rb.velocity = new Vector2(rb.velocity.x * -1, rb.velocity.y);
        if(collision.gameObject.tag == "Wall")
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * -1);
    }
}
