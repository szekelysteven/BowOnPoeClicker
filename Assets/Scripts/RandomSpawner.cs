//Steven Szekely

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public Transform prefab;
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
        if (this.tag == "Building1")
        {
            if (oldTime <= (currentTime - GameObject.Find("MathScript").GetComponent<MathScript>().building1SpawnRate))
            {
                oldTime = currentTime;
                if (GameObject.Find("MathScript").GetComponent<MathScript>().building1SpawnRate > 0)
                {
                    Spawn();
                }
            }
        }
        if (this.tag == "Building2")
        {
            if (oldTime <= (currentTime - GameObject.Find("MathScript").GetComponent<MathScript>().building2SpawnRate))
            {
                oldTime = currentTime;
                if (GameObject.Find("MathScript").GetComponent<MathScript>().building2SpawnRate > 0)
                {
                    Spawn();
                }
            }
        }
        if (this.tag == "Building3")
        {
            if (oldTime <= (currentTime - GameObject.Find("MathScript").GetComponent<MathScript>().building3SpawnRate))
            {
                oldTime = currentTime;
                if (GameObject.Find("MathScript").GetComponent<MathScript>().building3SpawnRate > 0)
                {
                    Spawn();
                }
            }
        }
    }

    public void Spawn()
    {
        Instantiate(prefab, transform.position + new Vector3(Random.Range(-SpawnX, SpawnX), Random.Range(-SpawnY, SpawnY)), Quaternion.identity);
    }

}
