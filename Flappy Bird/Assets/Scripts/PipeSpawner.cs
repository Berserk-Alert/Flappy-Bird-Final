using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 4;
    public float timer = 0;
    public float hOffset = 10;

    // Start is called before the first frame update    eat a shoe
    void Start()
    {
        spawnPipe();   
    }

    // Update is called once per frame
    void Update()
    {
        
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
        
    }

    void spawnPipe()
    {
        float highP = transform.position.y + hOffset;
        float lowP = transform.position.y - hOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowP, highP), 0) , transform.rotation);
    }
}


