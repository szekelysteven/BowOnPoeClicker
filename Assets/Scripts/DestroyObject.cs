using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    
    public float value;
    // Start is called before the first frame update
  

    void OnMouseDown()
    {
        GameObject.Find("MathScript").GetComponent<MathScript>().TotalMoney += value;
        Destroy(gameObject);
    }


}
