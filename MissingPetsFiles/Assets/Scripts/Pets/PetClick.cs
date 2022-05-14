using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetClick : MonoBehaviour
{
    public AudioSource noise;
    string clickMessage = "Click!";
    float hitBoxSize = 1f;
    

    
    // Start is called before the first frame update
    void Start()
    {
        noise = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) 
        {
            //makes a vector with the coordinates of the mouse position
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //a completely useless line of code, not even sure why its here
            //makes a copy of mousePos but without the z axis
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            //check collision with the mouse
            if(mousePos.x > transform.position.x - hitBoxSize &&
                mousePos.x < transform.position.x + hitBoxSize &&
                mousePos.y > transform.position.y - hitBoxSize &&
                mousePos.y < transform.position.y + hitBoxSize)
                if(this.gameObject.tag == ("BadPet"))
                {
                    noise.Play();
                    Destroy(this.gameObject);
                }
                if(this.gameObject.tag == ("GoodPet"))
                {
                    noise.Play();
                }
       
        }
    }
}
