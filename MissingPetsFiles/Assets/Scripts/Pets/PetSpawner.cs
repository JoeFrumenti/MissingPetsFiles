using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetSpawner : MonoBehaviour
{
    public GameObject BadPetPrefab;
    public GameObject GoodPetPrefab;
    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        int goodSpawn = Random.Range(0, 31);
        for (int i = -7; i <=7; i+=2)
            for(int j = -3; j <= 3; j+=2)
            {
                if (count == goodSpawn)
                {
                    GameObject obj = (GameObject)Instantiate(GoodPetPrefab, new Vector3(i, j, 0), Quaternion.identity);
                }
                else
                {
                    GameObject obj = (GameObject)Instantiate(BadPetPrefab, new Vector3(i, j, 0), Quaternion.identity);
                }
                count++;

            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
