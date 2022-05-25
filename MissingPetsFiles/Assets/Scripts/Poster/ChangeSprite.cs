using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite = new Sprite[5];

    // Start is called before the first frame update
    internal void Start()
    {
       spriteRenderer = GetComponent<SpriteRenderer>();
       UpdatePoster(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void UpdatePoster()
    {
        spriteRenderer.sprite = newSprite[GameObject.FindGameObjectWithTag("PetSpawner").GetComponent<PetSpawner>().correctPet]; 
    }
}
