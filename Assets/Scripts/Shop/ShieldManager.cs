using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldManager : MonoBehaviour
{
    public GameObject shield0;
    public GameObject shield1;
    public GameObject shield2;
    public GameObject shield3;
    public GameObject shield4;
    public GameObject shield5;
    public GameObject shield6;

    public string nameShield;

    void Update()
    {
        int shieldLevel;
        shieldLevel = PlayerPrefs.GetInt(nameShield);

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
                break;
            case 1:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(true);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                break;
            case 2:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(true);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                break;
            case 3:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(true);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                break;
            case 4:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(true);
                shield5.gameObject.SetActive(false);
                shield6.gameObject.SetActive(false);
                break;
            case 5:
                shield0.gameObject.SetActive(false);
                shield1.gameObject.SetActive(false);
                shield2.gameObject.SetActive(false);
                shield3.gameObject.SetActive(false);
                shield4.gameObject.SetActive(false);
                shield5.gameObject.SetActive(true);
                shield6.gameObject.SetActive(false);
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
}
