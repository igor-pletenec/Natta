using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public GameObject shieldCollider;
    public GameObject shield;
    public Button shieldButton;
    public Text shieldWork;

    private float timeOfWork;
    public float startTimeShield;
    public string nameShield;

    void Start()
    {
        shield.SetActive(false);
        shieldCollider.SetActive(false);
        shieldWork.enabled = false;
        shieldButton.onClick.AddListener(EnableShield);
        timeOfWork = PlayerPrefs.GetInt(nameShield) + startTimeShield;
    }

    void Update()
    {
        if (shield.gameObject == true && shieldWork.enabled == true && timeOfWork > 0 && shieldCollider.gameObject == true)
        {
            timeOfWork -= Time.deltaTime;
            shieldWork.text = ((int)timeOfWork).ToString();
        }
        else
        {
            shieldWork.enabled = false;
        }

        //if (Input.GetKeyDown(KeyCode.Space)) // убрать перед релизом 
        //{
        //    EnableShield();
        //    shieldWork.enabled = true;
        //}
    }

    public void EnableShield()
    {
        shield.SetActive(true);
        shieldCollider.SetActive(true);
        Destroy(shield, timeOfWork);
        Destroy(shieldCollider, timeOfWork);
        shieldButton.gameObject.SetActive(false);
        shieldWork.enabled = true;
    }
}
