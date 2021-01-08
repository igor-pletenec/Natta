using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    int money;
    int isSoldOrChoose;
    int getCharacter;

    public Text moneyText;
    public string MoneyName;
    public string ChoosePlayer;

    public int price;

    public Button buy;
    public Button deBuy;
    public Button choose;
    public Button chooseActive;

    public AudioSource audioSource;
    public AudioClip buySound;
    public AudioClip chooseSound;

    public int numOfCharacter;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Start()
    {
        money = PlayerPrefs.GetInt(MoneyName);
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);
    }

    void Update()
    {
        money = PlayerPrefs.GetInt(MoneyName);
        moneyText.text = money.ToString();

        isSoldOrChoose = PlayerPrefs.GetInt(ChoosePlayer);

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

        if (PlayerPrefs.GetInt(selectedCharacter) != numOfCharacter && isSoldOrChoose == 2)
        {
            PlayerPrefs.SetInt(ChoosePlayer, 1);
        }

    }
    public void Buy()
    {
        money -= price;
        audioSource.PlayOneShot(buySound);
        PlayerPrefs.SetInt(ChoosePlayer, 1);
        PlayerPrefs.SetInt(MoneyName, money);
    }

    public void ChooseActive()
    {
        audioSource.PlayOneShot(chooseSound);
        PlayerPrefs.SetInt(ChoosePlayer, 2);
        PlayerPrefs.SetInt(selectedCharacter, numOfCharacter);
    }

    public void ResetPrefs()
    {
        money = 0;
        PlayerPrefs.DeleteAll();
    }
}
