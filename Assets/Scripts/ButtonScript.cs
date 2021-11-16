using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
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

    private AudioSource audioSource;

    [SerializeField] TextMeshProUGUI leveloneText;
    [SerializeField] TextMeshProUGUI leveltwoText;
    [SerializeField] TextMeshProUGUI levelthreeText;
    int b1;
    int b2;
    int b3;
    public int totalLevel;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        b1 = 1;
        b2 = 0;
        b3 = 0;
        totalLevel = 1;
        leveloneText.text = b1.ToString();
        leveltwoText.text = b2.ToString();
        levelthreeText.text = b3.ToString();
    }

    // Update is called once per frame
    void Update()
    {
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

        EndGame();
    }
    public void OnPressBuildingOne()
    {
        if ((totalMoney >= building1UpgradeCost) && building1Level < 3)
        {
            GameObject.Find("MathScript").GetComponent<MathScript>().totalMoney -= building1UpgradeCost;
            GameObject.Find("MathScript").GetComponent<MathScript>().building1UpgradeCost += building1UpgradeCost;
            GameObject.Find("MathScript").GetComponent<MathScript>().building1Level++;
            GameObject.Find("MathScript").GetComponent<MathScript>().building1SpawnRate /= 2;
            GameObject.Find("MathScript").GetComponent<MathScript>().donator1Multiplier *= 2;
            audioSource.Play();
            b1 = b1 + 1;
            leveloneText.text = b1.ToString();
            totalLevel = totalLevel + 1;
            EndGame();
        }
    }
    public void OnPressBuildingTwo()
    {
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
            audioSource.Play();
            b2 = b2 + 1;
            leveltwoText.text = b2.ToString();
            totalLevel = totalLevel + 1;
            EndGame();
        }
    }
    public void OnPressBuildingThree()
    {
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
            audioSource.Play();
            b3 = b3 + 1;
            levelthreeText.text = b3.ToString();
            totalLevel = totalLevel + 1;
            EndGame();
        }
    }
    public void EndGame()
    {
        if (totalLevel == 9)
        {
            SceneManager.LoadScene("Win Screen");
        }
    }
}
