using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManagerSnail : MonoBehaviour
{
    int isSoldOrChoose;
    int getCharacter;

    public string ChoosePlayer;

    public Button choose;
    public Button chooseActive;

    public AudioSource audioSource;
    public AudioClip chooseSound;

    public int numOfCharacter;
    private readonly string selectedCharacter = "SelectedCharacter";

    void Start()
    {
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        if (PlayerPrefs.GetInt(ChoosePlayer, 0) == 0)
        {
            PlayerPrefs.SetInt(ChoosePlayer, 2);
        }

        if (PlayerPrefs.GetInt(selectedCharacter, 0) == 0)
        {
            PlayerPrefs.SetInt(selectedCharacter, 10);
            isSoldOrChoose = 2;
        }
    }

    void Update()
    {

        isSoldOrChoose = PlayerPrefs.GetInt(ChoosePlayer);

        if (isSoldOrChoose == 1)
        {
            choose.gameObject.SetActive(false);
            chooseActive.gameObject.SetActive(true);
        }
        else if (isSoldOrChoose == 2)
        {
            choose.gameObject.SetActive(true);
            chooseActive.gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt(selectedCharacter) != numOfCharacter && isSoldOrChoose == 2)
        {
            PlayerPrefs.SetInt(ChoosePlayer, 1);
        }

    }

    public void ChooseActive()
    {
        audioSource.PlayOneShot(chooseSound);
        PlayerPrefs.SetInt(selectedCharacter, numOfCharacter);
        PlayerPrefs.SetInt(ChoosePlayer, 2);
    }
}
