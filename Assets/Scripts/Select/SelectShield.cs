using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectShield : MonoBehaviour
{
    public GameObject shield0;
    public GameObject shield1;
    public GameObject shield2;
    public GameObject shield3;
    public GameObject shield4;
    public GameObject shield5;
    public GameObject shield6;

    public Button buyShield;
    public Button deBuyShield;

    public Text shieldPrice;
    public Text deShieldPrice;
    public Text shieldTime;

    public int startShieldTime;
    public int levelShield;

    private int priceShield;
    private int money;

    public string nameShield;

    public AudioSource audioSource;
    public AudioClip buySound;

    void Start()
    {
        money = PlayerPrefs.GetInt("MoneyGold");
    }

    void Update()
    {
        int shieldLevel;
        shieldLevel = PlayerPrefs.GetInt(nameShield);
        shieldTime.text = (shieldLevel + startShieldTime).ToString();
        shieldPrice.text = priceShield.ToString();
        deShieldPrice.text = priceShield.ToString();
        money = PlayerPrefs.GetInt("MoneyGold");

        if (money >= 5 && shieldLevel == 0)
        {
            buyShield.gameObject.SetActive(true);
            deBuyShield.gameObject.SetActive(false);
        }
        else if (money < 5 && shieldLevel == 0)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
        }
        else if (money >= 10 && shieldLevel == 1)
        {
            buyShield.gameObject.SetActive(true);
            deBuyShield.gameObject.SetActive(false);
        }
        else if (money < 10 && shieldLevel == 1)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
        }
        else if (money >= 15 && shieldLevel == 2)
        {
            buyShield.gameObject.SetActive(true);
            deBuyShield.gameObject.SetActive(false);
        }
        else if (money < 15 && shieldLevel == 2)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
        }
        else if (money >= 20 && shieldLevel == 3)
        {
            buyShield.gameObject.SetActive(true);
            deBuyShield.gameObject.SetActive(false);
        }
        else if (money < 20 && shieldLevel == 3)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
        }
        else if (money >= 25 && shieldLevel == 4)
        {
            buyShield.gameObject.SetActive(true);
            deBuyShield.gameObject.SetActive(false);
        }
        else if (money < 25 && shieldLevel == 4)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
        }
        else if (money >= 30 && shieldLevel == 5)
        {
            buyShield.gameObject.SetActive(true);
            deBuyShield.gameObject.SetActive(false);
        }
        else if (money < 30 && shieldLevel == 5)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
        }
        else if (shieldLevel == 6)
        {
            buyShield.gameObject.SetActive(false);
            deBuyShield.gameObject.SetActive(true);
            deShieldPrice.text = "IGR";
        }

        switch (shieldLevel)
        {
            case 0:
                shield0.gameObject.SetActive(true);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                priceShield = 5;
                levelShield = 1;
                break;
            case 1:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(true);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                priceShield = 10;
                levelShield = 2;
                break;
            case 2:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(true);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                priceShield = 15;
                levelShield = 3;
                break;
            case 3:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(true);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                priceShield = 20;
                levelShield = 4;
                break;
            case 4:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(true);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                priceShield = 25;
                levelShield = 5;
                break;
            case 5:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(true);
                shield6.gameObject.SetActive(false);
                priceShield = 30;
                levelShield = 6;
                break;
            case 6:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(true);
                break;
            default:
                shield0.gameObject.SetActive(true);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                break;
        }
    }

    public void LevelUp()
    {
        money -= priceShield;
        audioSource.PlayOneShot(buySound);
        PlayerPrefs.SetInt(nameShield, levelShield);
        PlayerPrefs.SetInt("MoneyGold", money);
    }

    public void ResetPrefs()
    {
        money = 0;
        PlayerPrefs.DeleteAll();
    }
}
