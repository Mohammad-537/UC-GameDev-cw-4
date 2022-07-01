

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject nemesisObject;
    public GameObject mrXObject;
    public GameObject zombiesObject;

    void Spawn()
    {

        GameObject spawnObject;
        int choice = Random.Range(0, 3);

        if (choice == 1)
        {
            spawnObject = nemesisObject;
        }
        else if (choice == 2)
        {
            spawnObject = mrXObject;
        }
        else
        {
            spawnObject = zombiesObject;
        }
        int newPosition = Random.Range(-1, 2);

        Vector3 some = transform.position;
        GameObject newSpawn = Instantiate(spawnObject);
        if (choice == 1 || choice == 2)
        {

            some.x = some.x + (newPosition * (7 + (1 / 2)));
            //GameObject newSpawn = Instantiate(spawnObject);
            newSpawn.transform.position = some;
        }
        else
        {



            newSpawn.transform.position = some;

        }

        //some.x = some.x + (newPosition * (7 + (1 / 2)));
        //GameObject newSpawn = Instantiate(spawnObject);
        //newSpawn.transform.position = some;



    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }
}


