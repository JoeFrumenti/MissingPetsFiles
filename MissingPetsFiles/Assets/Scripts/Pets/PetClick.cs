using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetClick : MonoBehaviour
{
    internal AudioSource noise;
    //string clickMessage = "Click!";
    float hitBoxSize = 1f;

    BoxCollider2D collider2D;

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
        collider2D = GetComponent<BoxCollider2D>();
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
        //     //makes a vector with the coordinates of the mouse position
        //     Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //     //a completely useless line of code, not even sure why its here
        //     //makes a copy of mousePos but without the z axis
        //     Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
        //     //check collision with the mouse
        //     if(mousePos.x > this.transform.position.x - hitBoxSize &&
        //         mousePos.x < this.transform.position.x + hitBoxSize &&
        //         mousePos.y > this.transform.position.y - hitBoxSize &&
        //         mousePos.y < this.transform.position.y + hitBoxSize)
        //         {
                    
        //         }
       
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(collider2D.OverlapPoint(mousePosition))
            {
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
