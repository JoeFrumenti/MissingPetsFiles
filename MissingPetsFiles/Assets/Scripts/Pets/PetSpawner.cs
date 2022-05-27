using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetSpawner : MonoBehaviour
{
    public GameObject BadPetPrefab;
    public GameObject GoodPetPrefab;
    
    public GameObject[] respawns;

    public GameObject[] Pets = new GameObject[5];

    int count = 0;

    bool isRestarting = false;
    float resetTimer;

    internal int correctPet;


    // Start is called before the first frame update
    void Start()
    {
        correctPet = Random.Range(0,5);
        GameObject.FindGameObjectWithTag("Poster").GetComponent<ChangeSprite>().UpdatePoster();
        count = 0;
        isRestarting = false;
        print("Start called!");
        int petSpawn;
        GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>().setTimeRunning(true);
                

        int goodSpawn = Random.Range(0, 24);
        for (int i = -7; i <=3; i+=2)
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
        if(isRestarting)
        {
            resetTimer+= Time.deltaTime;
        }

        if(resetTimer >=2)
        {
            isRestarting = false;
            resetTimer = 0;
            Destroy(GameObject.FindGameObjectWithTag("GoodPet"));
            Start();
        }
    }

    internal void respawn()
    {
        print("respawning!");
        
        respawns = GameObject.FindGameObjectsWithTag("BadPet");
        for(int i = 0; i < respawns.Length; i++)
        {
            Destroy(respawns[i]);
        }
        isRestarting = true;
    }
}
