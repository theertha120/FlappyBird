using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
   
    // Start is called before the first frame update
    void Start()
    {


        spawnie();

    }

    // Update is called once per frame
    void Update()
    {
        if (spawnRate > timer)
        {
            timer = timer + Time.deltaTime;
        }

        else
        {

            spawnie();
            timer = 0;
        }
    }

    void spawnie()
    {
        float lowest = (float)(transform.position.y - 3.8);
        float highest = (float)(transform.position.y + 4);
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowest, highest),0), transform.rotation);
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;

    // Minimum and maximum heights for the pipes
    public float minHeight = -13; //-22
    public float maxHeight = 7; //16

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    void SpawnPipe()
    {
        float randomHeight = Random.RandomRange(minHeight, maxHeight);
        Vector3 position = new Vector3(12, randomHeight, 0);
        Instantiate(Pipe, position, Quaternion.identity);
    }
}
*/
