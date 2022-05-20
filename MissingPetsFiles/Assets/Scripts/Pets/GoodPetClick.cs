using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodPetClick : MonoBehaviour
{
    internal AudioSource noise;
    //string clickMessage = "Click!";
    float hitBoxSize = 1f;

    PolygonCollider2D collider2D;

    bool isDying = false;
    float deathNoiseTime = 0.1f;
    float deathTimer = 0f;
    

    void Awake()
    {
        noise = this.GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<PolygonCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDying)
        {
            deathTimer += Time.deltaTime;
        }

        if(deathTimer >= deathNoiseTime)
            Destroy(this.gameObject);

         if (Input.GetMouseButtonDown(0)) 
        {
       
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(collider2D.OverlapPoint(mousePosition))
            {
                print(this.gameObject.tag);
                if(this.gameObject.tag == ("BadPet"))
                {
                    noise.Play();
                    isDying = true;
                }
                if(this.gameObject.tag == ("GoodPet"))
                {
                    noise.Play();
                }
            }


        }
    }
}
