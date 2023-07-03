using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BygnignSpawnScript : MonoBehaviour
{
    public GameObject Skyscraper;
    public float SpawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnSkyscraper();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnSkyscraper(); 
            timer = 0;
        }

        
    }

    void spawnSkyscraper()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(Skyscraper, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
