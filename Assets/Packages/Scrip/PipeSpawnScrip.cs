using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScrip : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 1;
    private float timer = 0;
    public float heightOffset = 1;
    // Start is called before the first frame update
    void Start()
    {
        
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
        float lowestPoint = transform.position.y - heightOffset;
        float hightestpoit = transform.position.y + heightOffset;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, hightestpoit),0),transform.rotation);
    }
}
