using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    
    private float value;
    private float donatorMultiplier;
    private float donatorValue;
    // Start is called before the first frame update

    private AudioSource audioSource;
    public Transform prefab;

    void Update()
    {
        Calculate();
    }
  

    void OnMouseOver()
    {
        //Updates public variable total money before object is destroyed.
        GameObject.Find("MathScript").GetComponent<MathScript>().totalMoney += value;
        Instantiate(prefab, transform.position + new Vector3(), Quaternion.identity);
        Destroy(gameObject);
    }

    //This will assign and update a donator value as buildings are leveled up.
    public void Calculate()
    {
        if (this.tag == "Donator1")
        {
            donatorMultiplier = GameObject.Find("MathScript").GetComponent<MathScript>().donator1Multiplier;
            value = GameObject.Find("MathScript").GetComponent<MathScript>().donator1Value;
            value = value * donatorMultiplier;
        }
        if (this.tag == "Donator2")
        {
            donatorMultiplier = GameObject.Find("MathScript").GetComponent<MathScript>().donator2Multiplier;
            value = GameObject.Find("MathScript").GetComponent<MathScript>().donator2Value;
            value = value * donatorMultiplier;
        }
        if (this.tag == "Donator3")
        {
            donatorMultiplier = GameObject.Find("MathScript").GetComponent<MathScript>().donator3Multiplier;
            value = GameObject.Find("MathScript").GetComponent<MathScript>().donator3Value;
            value = value * donatorMultiplier;
        }
    }

}
