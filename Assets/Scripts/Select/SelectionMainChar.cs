using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMainChar : MonoBehaviour
{
    public GameObject Snail;
    public GameObject Turtle;
    public GameObject Pig;
    public GameObject Trunk;
    public GameObject BlueBird;
    public GameObject Ghost;
    public GameObject Radish;
    public GameObject Skull;
    public GameObject Bat;
    public GameObject HellSkull;

    private readonly string selectedCharacter = "SelectedCharacter";

    void Awake()
    {
        int getCharacter;
        getCharacter = PlayerPrefs.GetInt(selectedCharacter);

        switch (getCharacter)
        {
            case 1:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(true);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 2:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(true);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 3:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(true);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 4:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(true);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 5:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(true);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 6:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(true);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 7:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(true);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            case 8:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(true);
                HellSkull.gameObject.SetActive(false);
                break;
            case 9:
                Snail.gameObject.SetActive(false);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(true);
                break;
            case 10:
                Snail.gameObject.SetActive(true);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
            default:
                Snail.gameObject.SetActive(true);
                Turtle.gameObject.SetActive(false);
                Pig.gameObject.SetActive(false);
                Trunk.gameObject.SetActive(false);
                BlueBird.gameObject.SetActive(false);
                Ghost.gameObject.SetActive(false);
                Radish.gameObject.SetActive(false);
                Skull.gameObject.SetActive(false);
                Bat.gameObject.SetActive(false);
                HellSkull.gameObject.SetActive(false);
                break;
        }
    }
}
