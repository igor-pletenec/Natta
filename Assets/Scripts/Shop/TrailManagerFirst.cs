using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrailManagerFirst : MonoBehaviour
{
    int isSoldOrChoose;
    int getTrail;

    public string ChooseTrail;

    public Button choose;
    public Button chooseActive;

    public AudioSource audioSource;
    public AudioClip chooseSound;

    public int numOfTrail;
    private readonly string selectedTrail = "SelectedTrail";

    void Start()
    {
        getTrail = PlayerPrefs.GetInt(selectedTrail);

        if (PlayerPrefs.GetInt(ChooseTrail, 0) == 0)
        {
            PlayerPrefs.SetInt(ChooseTrail, 2);
        }

        if (PlayerPrefs.GetInt(selectedTrail, 0) == 0)
        {
            PlayerPrefs.SetInt(selectedTrail, 10);
            isSoldOrChoose = 2;
        }
    }

    void Update()
    {

        isSoldOrChoose = PlayerPrefs.GetInt(ChooseTrail);

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

        if (PlayerPrefs.GetInt(selectedTrail) != numOfTrail && isSoldOrChoose == 2)
        {
            PlayerPrefs.SetInt(ChooseTrail, 1);
        }

    }

    public void ChooseActive()
    {
        audioSource.PlayOneShot(chooseSound);
        PlayerPrefs.SetInt(selectedTrail, numOfTrail);
        PlayerPrefs.SetInt(ChooseTrail, 2);
    }
}
