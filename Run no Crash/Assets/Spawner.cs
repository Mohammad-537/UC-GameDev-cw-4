using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject nemesisObject;
    public GameObject mrXObject;

    void Spawn()
    {

        GameObject spawnObject;
        int choice = Random.Range(0, 2);

        if (choice == 1)
        {
            spawnObject = nemesisObject;
        }
        else
        {
            spawnObject = mrXObject;
        }
        int newPosition = Random.Range(-1, 2);
        
        Vector3 some = transform.position;
        some.x = some.x + (newPosition * (7 + (1 / 2)));
        GameObject newSpawn = Instantiate(spawnObject);
        newSpawn.transform.position = some;

        

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
