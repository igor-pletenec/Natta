using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrailManager : MonoBehaviour
{
    int money;
    int isSoldOrChoose;
    int getTrail;

    public Text moneyText;
    public string ChooseTrail;
    public int price;

    public Button buy;
    public Button deBuy;
    public Button choose;
    public Button chooseActive;

    public AudioSource audioSource;
    public AudioClip buySound;
    public AudioClip chooseSound;

    public int numOfTrail;
    private readonly string selectedTrail = "SelectedTrail";

    void Start()
    {
        money = PlayerPrefs.GetInt("MoneyGold");
        getTrail = PlayerPrefs.GetInt(selectedTrail);
    }

    void Update()
    {
        moneyText.text = money.ToString();
        money = PlayerPrefs.GetInt("MoneyGold");

        isSoldOrChoose = PlayerPrefs.GetInt(ChooseTrail);

        if (money >= price && isSoldOrChoose == 0)
        {
            buy.gameObject.SetActive(true);
            deBuy.gameObject.SetActive(false);
            choose.gameObject.SetActive(false);
            chooseActive.gameObject.SetActive(false);
        }
        else if (money < price && isSoldOrChoose == 0)
        {
            buy.gameObject.SetActive(false);
            deBuy.gameObject.SetActive(true);
            choose.gameObject.SetActive(false);
            chooseActive.gameObject.SetActive(false);
        }
        else if (isSoldOrChoose == 1)
        {
            buy.gameObject.SetActive(false);
            deBuy.gameObject.SetActive(false);
            choose.gameObject.SetActive(false);
            chooseActive.gameObject.SetActive(true);
        }
        else if (isSoldOrChoose == 2)
        {
            buy.gameObject.SetActive(false);
            deBuy.gameObject.SetActive(false);
            choose.gameObject.SetActive(true);
            chooseActive.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt(selectedTrail) != numOfTrail && isSoldOrChoose == 2)
        {
            PlayerPrefs.SetInt(ChooseTrail, 1);
        }

    }
    public void Buy()
    {
        money -= price;
        audioSource.PlayOneShot(buySound);
        PlayerPrefs.SetInt(ChooseTrail, 1);
        PlayerPrefs.SetInt("MoneyGold", money);
    }

    public void ChooseActive()
    {
        audioSource.PlayOneShot(chooseSound);
        PlayerPrefs.SetInt(ChooseTrail, 2);
        PlayerPrefs.SetInt(selectedTrail, numOfTrail);
    }

    public void ResetPrefs()
    {
        money = 0;
        PlayerPrefs.DeleteAll();
    }
}
