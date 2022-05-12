using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetClick : MonoBehaviour
{
    
    string clickMessage = "Click!";
    float hitBoxSize = 1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButtonDown(0)) 
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            if(mousePos.x > transform.position.x - hitBoxSize &&
                mousePos.x < transform.position.x + hitBoxSize &&
                mousePos.y > transform.position.y - hitBoxSize &&
                mousePos.y < transform.position.y + hitBoxSize)
                if(this.gameObject.tag == ("BadPet"))
                    Destroy(this.gameObject);
        }
    }
}
