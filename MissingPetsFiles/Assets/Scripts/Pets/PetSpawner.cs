using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetSpawner : MonoBehaviour
{
    public GameObject BadPetPrefab;
    public GameObject GoodPetPrefab;

    public GameObject[] Pets = new GameObject[5];

    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        int correctPet = Random.Range(0,5);
        int petSpawn;

        int goodSpawn = Random.Range(0, 31);
        for (int i = -7; i <=7; i+=2)
            for(int j = -3; j <= 3; j+=2)
            {

                //Generate and int for the "incorrect" pet to spawn
                petSpawn = Random.Range(0,5);

                //If chosen pet is the correct pet, shift it over
                //also shifted everything else over to keep it looking more random
                if(petSpawn >= correctPet)
                    petSpawn ++;
                if(petSpawn > 4)
                {
                    petSpawn = 0;
                    if(correctPet == 0)
                        petSpawn++;
                }

                if (count == goodSpawn)
                {
                    GameObject obj = (GameObject)Instantiate(Pets[correctPet], new Vector3(i, j, 0), Quaternion.identity);
                    obj.gameObject.tag = "GoodPet";
                }
                else
                {
                    GameObject obj = (GameObject)Instantiate(Pets[petSpawn], new Vector3(i, j, 0), Quaternion.identity);
                    obj.gameObject.tag = "BadPet";

                }
                count++;

            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
