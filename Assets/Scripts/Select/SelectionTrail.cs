using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionTrail : MonoBehaviour
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

    private Vector3 TrailPosition;
    private Vector3 OffScreen;

    private int trailInt = 1;

    private void Awake()

    {
        TrailPosition = Trail1.transform.position;
        OffScreen = Trail2.transform.position;
    }

    public void NextTrail()
    {
        switch (trailInt)
        {
            case 1:
                Trail1.transform.position = OffScreen;
                Trail2.transform.position = TrailPosition;
                trailInt++;
                break;
            case 2:
                Trail2.transform.position = OffScreen;
                Trail3.transform.position = TrailPosition;
                trailInt++;
                break;
            case 3:
                Trail3.transform.position = OffScreen;
                Trail4.transform.position = TrailPosition;
                trailInt++;
                break;
            case 4:
                Trail4.transform.position = OffScreen;
                Trail5.transform.position = TrailPosition;
                trailInt++;
                break;
            case 5:
                Trail5.transform.position = OffScreen;
                Trail6.transform.position = TrailPosition;
                trailInt++;
                break;
            case 6:
                Trail6.transform.position = OffScreen;
                Trail7.transform.position = TrailPosition;
                trailInt++;
                break;
            case 7:
                Trail7.transform.position = OffScreen;
                Trail8.transform.position = TrailPosition;
                trailInt++;
                break;
            case 8:
                Trail8.transform.position = OffScreen;
                Trail9.transform.position = TrailPosition;
                trailInt++;
                break;
            case 9:
                Trail9.transform.position = OffScreen;
                Trail10.transform.position = TrailPosition;
                trailInt++;
                break;
            case 10:
                Trail10.transform.position = OffScreen;
                Trail1.transform.position = TrailPosition;
                trailInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void PreviousTrail()
    {
        switch (trailInt)
        {
            case 1:
                Trail1.transform.position = OffScreen;
                Trail10.transform.position = TrailPosition;
                ResetInt();
                break;
            case 2:
                Trail2.transform.position = OffScreen;
                Trail1.transform.position = TrailPosition;
                trailInt--;
                break;
            case 3:
                Trail3.transform.position = OffScreen;
                Trail2.transform.position = TrailPosition;
                trailInt--;
                break;
            case 4:
                Trail4.transform.position = OffScreen;
                Trail3.transform.position = TrailPosition;
                trailInt--;
                break;
            case 5:
                Trail5.transform.position = OffScreen;
                Trail4.transform.position = TrailPosition;
                trailInt--;
                break;
            case 6:
                Trail6.transform.position = OffScreen;
                Trail5.transform.position = TrailPosition;
                trailInt--;
                break;
            case 7:
                Trail7.transform.position = OffScreen;
                Trail6.transform.position = TrailPosition;
                trailInt--;
                break;
            case 8:
                Trail8.transform.position = OffScreen;
                Trail7.transform.position = TrailPosition;
                trailInt--;
                break;
            case 9:
                Trail9.transform.position = OffScreen;
                Trail8.transform.position = TrailPosition;
                trailInt--;
                break;
            case 10:
                Trail10.transform.position = OffScreen;
                Trail9.transform.position = TrailPosition;
                trailInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (trailInt >= 10) // количество персонажей
        {
            trailInt = 1;
        }
        else
        {
            trailInt = 10;
        }
    }

}
