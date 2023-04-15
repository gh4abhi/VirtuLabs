using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] obstacle;
    private float timeBtweenSpawn;
    public float startTime;
    public float decreaseTime;
    public float minTime = 0.65f;

    void Update()
    {
        if(timeBtweenSpawn<=0)
        {
            int rand = Random.Range(0,obstacle.Length);
            Instantiate(obstacle[rand], transform.position, Quaternion.identity);
            timeBtweenSpawn = startTime;
            if(startTime>minTime)
                startTime -= decreaseTime;
        }
        else
        {
            timeBtweenSpawn -= Time.deltaTime;
        }
    }
}
