   //Steven Szekely

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MathScript : MonoBehaviour
{
    //We want buildings to have three levels each. The levels will affect how fast that building produces units
    //and increases donator values from the building.
    public float totalMoney = 0;

    //Sets initial building costs for buildings at level 1.
    public float building1UpgradeCost = 2000;
    public float building2UpgradeCost = 4000;
    public float building3UpgradeCost = 8000;

    //These will increase with building levels.
    public float donator1Multiplier = 1;
    public float donator2Multiplier = 1;
    public float donator3Multiplier = 1;

    public float donator1Value;
    public float donator2Value;
    public float donator3Value;

    public float building1Level;
    public float building2Level;
    public float building3Level;

    public float building1SpawnRate;
    public float building2SpawnRate;
    public float building3SpawnRate;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {       
        Debug.Log(totalMoney);

    }

 
}
