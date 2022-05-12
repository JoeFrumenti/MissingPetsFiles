using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSpawner : MonoBehaviour
{
    public GameObject BadPetPrefab;
    int count = 0;
    int countCap = 10;


    // Start is called before the first frame update
    void Start()
    {
        for(int i = -7; i <=7; i+=2)
            for(int j = -3; j <= 3; j+=2)
            {
                GameObject obj = (GameObject)Instantiate(BadPetPrefab, new Vector3(i, j, 0), Quaternion.identity);
                count ++;
                if(countCap == count)
                    obj.gameObject.tag = "GoodPet";

            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
