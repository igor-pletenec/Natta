using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    int money;
    int isOpenOrClosed;

    public Button buy;
    public Button deBuy;
    public Button close;
    public Button open;

    public string MoneyName;
    public string ChooseLevel;
    public int price;

    void Start()
    {
        money = PlayerPrefs.GetInt(MoneyName);
    }

    void Update()
    {
        money = PlayerPrefs.GetInt(MoneyName);
        isOpenOrClosed = PlayerPrefs.GetInt(ChooseLevel);

        if (money >= price && isOpenOrClosed == 0)
        {
            buy.gameObject.SetActive(true);
            deBuy.gameObject.SetActive(false);
            close.gameObject.SetActive(true);
            open.gameObject.SetActive(false);
        }
        else if (money < price && isOpenOrClosed == 0)
        {
            buy.gameObject.SetActive(false);
            deBuy.gameObject.SetActive(true);
            close.gameObject.SetActive(true);
            open.gameObject.SetActive(false);
        }
        else if (isOpenOrClosed == 1)
        {
            buy.gameObject.SetActive(false);
            deBuy.gameObject.SetActive(false);
            close.gameObject.SetActive(false);
            open.gameObject.SetActive(true);
        }
    }

    public void Buy()
    {
        money -= price;
        PlayerPrefs.SetInt(ChooseLevel, 1);
        PlayerPrefs.SetInt(MoneyName, money);
    }

    public void Back()
    {
        PlayerPrefs.SetInt(MoneyName, money);
    }
}
