//Steven Szekely

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform prefab;
    public float SpawnRate;
    //SpawnX and SpawnY are the boundries of the spawner.
    [Tooltip("Min and Max X Values")]
    public float SpawnX;
    [Tooltip("Min and Max Y Values")]
    public float SpawnY;
    private float oldTime;
    private float currentTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Timer();
    }

    public void Timer()
    {
        //increases time
        currentTime += Time.deltaTime;
        //checks if spawnrate time has passed
        if (oldTime <= (currentTime - SpawnRate))
        {
            oldTime = currentTime;
            Spawn();
        }
    }

    public void Spawn()
    {
        Instantiate(prefab, transform.position + new Vector3(Random.Range(-SpawnX, SpawnX), Random.Range(-SpawnY, SpawnY)), Quaternion.identity);
    }

}
