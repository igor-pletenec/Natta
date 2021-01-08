using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMoney : MonoBehaviour
{
    public static int moneyGold;
    public static int moneyTurtle;
    public static int moneyCandy;
    public static int moneyLog;
    public static int moneyFeather;
    public static int moneyFish;
    public static int moneyDice;
    public static int moneyHorn;
    public static int moneyPowder;
    public static int moneyHell;

    public Text GoldMoney;
    public Text OtherMoney;
    public int coinLevel;

    void Update()
    {
        GoldMoney.text = moneyGold.ToString();
        switch (coinLevel)
        {
            case 1:
                OtherMoney.text = moneyTurtle.ToString();
                break;
            case 2:
                OtherMoney.text = moneyCandy.ToString();
                break;
            case 3:
                OtherMoney.text = moneyLog.ToString();
                break;
            case 4:
                OtherMoney.text = moneyFeather.ToString();
                break;
            case 5:
                OtherMoney.text = moneyFish.ToString();
                break;
            case 6:
                OtherMoney.text = moneyDice.ToString();
                break;
            case 7:
                OtherMoney.text = moneyHorn.ToString();
                break;
            case 8:
                OtherMoney.text = moneyPowder.ToString();
                break;
            case 9:
                OtherMoney.text = moneyHell.ToString();
                break;
        }
    }

    void Start()
    {
        moneyGold = PlayerPrefs.GetInt("MoneyGold");
        moneyTurtle = PlayerPrefs.GetInt("MoneyTurtle");
        moneyCandy = PlayerPrefs.GetInt("MoneyCandy");
        moneyLog = PlayerPrefs.GetInt("MoneyLog");
        moneyFeather = PlayerPrefs.GetInt("MoneyFeather");
        moneyFish = PlayerPrefs.GetInt("MoneyFish");
        moneyDice = PlayerPrefs.GetInt("MoneyDice");
        moneyHorn = PlayerPrefs.GetInt("MoneyHorn");
        moneyPowder = PlayerPrefs.GetInt("MoneyPowder");
        moneyHell = PlayerPrefs.GetInt("MoneyHell");
    }

    public void RestartOrHome()
    {
        PlayerPrefs.SetInt("MoneyGold", moneyGold);
        PlayerPrefs.SetInt("MoneyTurtle", moneyTurtle);
        PlayerPrefs.SetInt("MoneyCandy", moneyCandy);
        PlayerPrefs.SetInt("MoneyLog", moneyLog);
        PlayerPrefs.SetInt("MoneyFeather", moneyFeather);
        PlayerPrefs.SetInt("MoneyFish", moneyFish);
        PlayerPrefs.SetInt("MoneyDice", moneyDice);
        PlayerPrefs.SetInt("MoneyHorn", moneyHorn);
        PlayerPrefs.SetInt("MoneyPowder", moneyPowder);
        PlayerPrefs.SetInt("MoneyHell", moneyHell);
    }
}
