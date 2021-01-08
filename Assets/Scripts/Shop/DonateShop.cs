using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonateShop : MonoBehaviour
{
    // добавить условие покупки за реал

    private int moneyGold;
    private int moneyTurtle;
    private int moneyCandy;
    private int moneyLog;
    private int moneyFeather;
    private int moneyFish;
    private int moneyDice;
    private int moneyHorn;
    private int moneyPowder;
    private int moneyHell;

    public AudioSource audioSource1;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioClip buySound;

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

    public void Buy10()
    {
        audioSource1.PlayOneShot(buySound);
        moneyGold += 10;
        moneyTurtle += 10;
        moneyCandy += 10;
        moneyLog += 10;
        moneyFeather += 10;
        moneyFish += 10;
        moneyDice += 10;
        moneyHorn += 10;
        moneyPowder += 10;
        moneyHell += 10;
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

    public void Buy50()
    {
        audioSource2.PlayOneShot(buySound);
        moneyGold += 50;
        moneyTurtle += 50;
        moneyCandy += 50;
        moneyLog += 50;
        moneyFeather += 50;
        moneyFish += 50;
        moneyDice += 50;
        moneyHorn += 50;
        moneyPowder += 50;
        moneyHell += 50;
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

    public void Buy100()
    {
        audioSource3.PlayOneShot(buySound);
        moneyGold += 100;
        moneyTurtle += 100;
        moneyCandy += 100;
        moneyLog += 100;
        moneyFeather += 100;
        moneyFish += 100;
        moneyDice += 100;
        moneyHorn += 100;
        moneyPowder += 100;
        moneyHell += 100;
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
