using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate;
    private float timer;
    public float heightOffset;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
        spawnRate = 6;
        timer = 0;
        heightOffset = 15;
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
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud()
    {

        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }

}
