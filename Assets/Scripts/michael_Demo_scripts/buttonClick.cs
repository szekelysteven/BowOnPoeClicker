using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonClick : MonoBehaviour
{
    public TMP_Text textBox;
    public float money;
    public int clickValue;   

    private void Start()
    {
        money = 0;
        clickValue = 1;
    }

    private void Update()
    {
        textBox.SetText("$ " + money);
    }

    public void click()
    {
        money += clickValue;
        Debug.Log(money);
    }

}
