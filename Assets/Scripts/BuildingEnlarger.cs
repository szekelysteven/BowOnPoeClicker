using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingEnlarger : MonoBehaviour
{
    public Transform building1;
    public Transform building2;
    public Transform building3;

    private float building1Level;
    private float building2Level;
    private float building3Level;

    //to make sure the loops only initiate once per level. place holder for better, more modular code in the future.
    private int ifCheck1 = 1;
    private int ifCheck2 = 1;
    private int ifCheck3 = 1;

    private float[] desiredScale = { 0f, 0f, 0f };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        building1Level = GameObject.Find("MathScript").GetComponent<MathScript>().building1Level;
        building2Level = GameObject.Find("MathScript").GetComponent<MathScript>().building2Level;
        building3Level = GameObject.Find("MathScript").GetComponent<MathScript>().building3Level;

        if (building1Level == 1 && ifCheck1 == 1)
        {
            ifCheck1 += 1;
            desiredScale[0] += 2f;
            building1.transform.localScale = new Vector3(desiredScale[0], desiredScale[0], desiredScale[0]);
        }

        if (building1Level == 2 && ifCheck1 == 2)
        {
            ifCheck1 += 1;
            desiredScale[0] += 1f;
            building1.transform.localScale = new Vector3(desiredScale[0], desiredScale[0], desiredScale[0]);
        }

        if (building1Level == 3 && ifCheck1 == 3)
        {
            ifCheck1 += 1;
            desiredScale[0] += 1f;
            building1.transform.localScale = new Vector3(desiredScale[0], desiredScale[0], desiredScale[0]);
        }










        if (building2Level == 0)
        {

            desiredScale[1] = 0f;
            building3.transform.localScale = new Vector3(desiredScale[1], desiredScale[1], desiredScale[1]);
        }
        if (building2Level == 1 && ifCheck2 == 1)
        {
            ifCheck2 += 1;
            desiredScale[1] += 2f;
            building2.transform.localScale = new Vector3(desiredScale[1], desiredScale[1], desiredScale[1]);
        }

        if (building2Level == 2 && ifCheck2 == 2)
        {
            ifCheck2 += 1;
            desiredScale[1] += 1f;
            building2.transform.localScale = new Vector3(desiredScale[1], desiredScale[1], desiredScale[1]);
        }

        if (building2Level == 3 && ifCheck2 == 3)
        {
            ifCheck2 += 1;
            desiredScale[1] += 1f;
            building2.transform.localScale = new Vector3(desiredScale[1], desiredScale[1], desiredScale[1]);
        }







        if (building3Level == 0)
        {
           
            desiredScale[2] = 0f;
            building3.transform.localScale = new Vector3(desiredScale[2], desiredScale[2], desiredScale[2]);
        }


        if (building3Level == 1 && ifCheck3 == 1)
        {
            ifCheck3 += 1;
            desiredScale[2] += 2f;
            building3.transform.localScale = new Vector3(desiredScale[2], desiredScale[2], desiredScale[2]);
        }

        if (building3Level == 2 && ifCheck3 == 2)
        {
            ifCheck3 += 1;
            desiredScale[2] += 1f;
            building3.transform.localScale = new Vector3(desiredScale[2], desiredScale[2], desiredScale[2]);
        }
        
        if (building3Level == 3 && ifCheck3 == 3)
        {
            ifCheck3 += 1;
            desiredScale[2] += 1f;
            building3.transform.localScale = new Vector3(desiredScale[2], desiredScale[2], desiredScale[2]);
        }

    }
}
