using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate = 2;
    public float timer = 0;

    // Start is called before the first frame update    eat a shoe
    void Start()
    {
        
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
            Instantiate(pipe, transform.position, transform.position);
            timer = 0;
        }
    }
}
