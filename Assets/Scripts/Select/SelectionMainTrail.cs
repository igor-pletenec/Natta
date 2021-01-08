using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMainTrail : MonoBehaviour
{
    public GameObject Trail1;
    public GameObject Trail2;
    public GameObject Trail3;
    public GameObject Trail4;
    public GameObject Trail5;
    public GameObject Trail6;
    public GameObject Trail7;
    public GameObject Trail8;
    public GameObject Trail9;
    public GameObject Trail10;

    private readonly string selectedTrail = "SelectedTrail";

    void Awake()
    {
        int getTrail;
        getTrail = PlayerPrefs.GetInt(selectedTrail);

        switch (getTrail)
        {
            case 1:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(true);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 2:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(true);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 3:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(true);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 4:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(true);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 5:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(true);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 6:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(true);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 7:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(true);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            case 8:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(true);
                Trail10.gameObject.SetActive(false);
                break;
            case 9:
                Trail1.gameObject.SetActive(false);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(true);
                break;
            case 10:
                Trail1.gameObject.SetActive(true);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
            default:
                Trail1.gameObject.SetActive(true);
                Trail2.gameObject.SetActive(false);
                Trail3.gameObject.SetActive(false);
                Trail4.gameObject.SetActive(false);
                Trail5.gameObject.SetActive(false);
                Trail6.gameObject.SetActive(false);
                Trail7.gameObject.SetActive(false);
                Trail8.gameObject.SetActive(false);
                Trail9.gameObject.SetActive(false);
                Trail10.gameObject.SetActive(false);
                break;
        }
    }
}
