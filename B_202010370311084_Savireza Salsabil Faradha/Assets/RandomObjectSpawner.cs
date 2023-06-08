using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject[] myObjects;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(1, 2), 1, Random.Range(1, 2));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }
}