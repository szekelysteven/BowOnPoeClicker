//Steven Szekely

//This is the script that will go onto the buildings to help keep track of clicks, upgrades and their costs.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuildingsClicker : MonoBehaviour
{
    //Syncs initial values to mathscript.
    private float totalMoney;

    private float building1UpgradeCost;
    private float building2UpgradeCost;
    private float building3UpgradeCost;

    private float building1Level;
    private float building2Level;
    private float building3Level;

    public TMP_Text moneyCount;
    public TMP_Text upgradeCostb1;
    public TMP_Text upgradeCostb2;
    public TMP_Text upgradeCostb3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update to keep totalmoney, building upgrade costs, and building levels in sync with math script global variables.
        totalMoney = GameObject.Find("MathScript").GetComponent<MathScript>().totalMoney;
        
        building1UpgradeCost = GameObject.Find("MathScript").GetComponent<MathScript>().building1UpgradeCost;
        building2UpgradeCost = GameObject.Find("MathScript").GetComponent<MathScript>().building2UpgradeCost;
        building3UpgradeCost = GameObject.Find("MathScript").GetComponent<MathScript>().building3UpgradeCost;

        building1Level = GameObject.Find("MathScript").GetComponent<MathScript>().building1Level;
        building2Level = GameObject.Find("MathScript").GetComponent<MathScript>().building2Level;
        building3Level = GameObject.Find("MathScript").GetComponent<MathScript>().building3Level;

        moneyCount.SetText("$ " + totalMoney);
        upgradeCostb1.SetText("$ " + building1UpgradeCost);
        upgradeCostb2.SetText("$ " + building2UpgradeCost);
        upgradeCostb3.SetText("$ " + building3UpgradeCost);
    }

    void OnMouseDown()
    {
        //This will subtract building cost from totalmoney and also raise double building cost when leveled up.
        if (this.tag == "Building1")
        {
            //Checks that the player has enough money for upgrade and isnt already level 3
            if ((totalMoney >= building1UpgradeCost) && building1Level < 3)
            {
                GameObject.Find("MathScript").GetComponent<MathScript>().totalMoney -= building1UpgradeCost;
                GameObject.Find("MathScript").GetComponent<MathScript>().building1UpgradeCost += building1UpgradeCost;
                GameObject.Find("MathScript").GetComponent<MathScript>().building1Level++;
                GameObject.Find("MathScript").GetComponent<MathScript>().building1SpawnRate /= 2;
                GameObject.Find("MathScript").GetComponent<MathScript>().donator1Multiplier *= 2;

            }
        }
        if (this.tag == "Building2")
        {
            //Checks that the player has enough money for upgrade and isnt already level 3
            if ((totalMoney >= building2UpgradeCost) && building2Level < 3)
            {
                //This extra 'if' statement is to make sure spawnrate isnt left at 0 when upgrading.
                if (building2Level == 0)
                {
                    GameObject.Find("MathScript").GetComponent<MathScript>().building2SpawnRate = 2;
                }
                GameObject.Find("MathScript").GetComponent<MathScript>().totalMoney -= building2UpgradeCost;
                GameObject.Find("MathScript").GetComponent<MathScript>().building2UpgradeCost += building2UpgradeCost;
                GameObject.Find("MathScript").GetComponent<MathScript>().building2Level++;
                GameObject.Find("MathScript").GetComponent<MathScript>().building2SpawnRate /= 2;
                GameObject.Find("MathScript").GetComponent<MathScript>().donator2Multiplier *= 2;
            }
        }
        if (this.tag == "Building3")
        {
            //Checks that the player has enough money for upgrade and isnt already level 3
            if ((totalMoney >= building3UpgradeCost) && building3Level < 3)
            {
                //This extra 'if' statement is to make sure spawnrate isnt left at 0 when upgrading.
                if (building3Level == 0)
                {
                    GameObject.Find("MathScript").GetComponent<MathScript>().building3SpawnRate = 2;
                }
                GameObject.Find("MathScript").GetComponent<MathScript>().totalMoney -= building3UpgradeCost;
                GameObject.Find("MathScript").GetComponent<MathScript>().building3UpgradeCost += building3UpgradeCost;
                GameObject.Find("MathScript").GetComponent<MathScript>().building3Level++;
                GameObject.Find("MathScript").GetComponent<MathScript>().building3SpawnRate /= 2;
                GameObject.Find("MathScript").GetComponent<MathScript>().donator3Multiplier *= 2;
            }
        }
    }
}
