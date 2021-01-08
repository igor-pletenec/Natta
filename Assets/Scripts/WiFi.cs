using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiFi : MonoBehaviour
{
    public GameObject checkWiFi;

    void Update()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            checkWiFi.gameObject.SetActive(true);
            PlayerPrefs.SetInt("CheckWifi", 1);
            //Debug.Log("Нет интернета!11");
        }
        else
        {
            checkWiFi.gameObject.SetActive(false);
            PlayerPrefs.SetInt("CheckWifi", 0);
            //Debug.Log("Ура, есть инет!");
        }
    }
}
