using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour
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

    private SpriteRenderer SnailRender, TurtleRender, PigRender,
                           TrunkRender, BlueBirdRender, GhostRender, 
                           RadishRender, SkullRender, BatRender, HellSkullRender;

    private Vector3 CharacterPosition;
    private Vector3 OffScreen;

    private int characterInt = 1;

    private void Awake()

    {
        CharacterPosition = Snail.transform.position;
        OffScreen = Turtle.transform.position;

        SnailRender = Snail.GetComponent<SpriteRenderer>();
        TurtleRender = Turtle.GetComponent<SpriteRenderer>();
        PigRender = Pig.GetComponent<SpriteRenderer>();
        TrunkRender = Trunk.GetComponent<SpriteRenderer>();
        BlueBirdRender = BlueBird.GetComponent<SpriteRenderer>();
        GhostRender = Ghost.GetComponent<SpriteRenderer>();
        RadishRender = Radish.GetComponent<SpriteRenderer>();
        SkullRender = Skull.GetComponent<SpriteRenderer>();
        BatRender = Bat.GetComponent<SpriteRenderer>();
        HellSkullRender = HellSkull.GetComponent<SpriteRenderer>();
    }

    public void NextCharacter()
    {
        switch (characterInt)
        {
            case 1:
                //PlayerPrefs.SetInt(selectedCharacter, 1);
                SnailRender.enabled = false;
                Snail.transform.position = OffScreen;
                TurtleRender.enabled = true;
                Turtle.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 2:
                //PlayerPrefs.SetInt(selectedCharacter, 2);
                TurtleRender.enabled = false;
                Turtle.transform.position = OffScreen;
                PigRender.enabled = true;
                Pig.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 3:
                //PlayerPrefs.SetInt(selectedCharacter, 3);
                PigRender.enabled = false;
                Pig.transform.position = OffScreen;
                TrunkRender.enabled = true;
                Trunk.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 4: 
                //PlayerPrefs.SetInt(selectedCharacter, 4); 
                TrunkRender.enabled = false;
                Trunk.transform.position = OffScreen;
                BlueBirdRender.enabled = true;
                BlueBird.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 5:
                //PlayerPrefs.SetInt(selectedCharacter, 5);
                BlueBirdRender.enabled = false;
                BlueBird.transform.position = OffScreen;
                GhostRender.enabled = true;
                Ghost.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 6:
                //PlayerPrefs.SetInt(selectedCharacter, 6);
                GhostRender.enabled = false;
                Ghost.transform.position = OffScreen;
                RadishRender.enabled = true;
                Radish.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 7:
                //PlayerPrefs.SetInt(selectedCharacter, 7);
                RadishRender.enabled = false;
                Radish.transform.position = OffScreen;
                SkullRender.enabled = true;
                Skull.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 8:
                //PlayerPrefs.SetInt(selectedCharacter, 8);
                SkullRender.enabled = false;
                Skull.transform.position = OffScreen;
                BatRender.enabled = true;
                Bat.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 9:
                //PlayerPrefs.SetInt(selectedCharacter, 9);
                BatRender.enabled = false;
                Bat.transform.position = OffScreen;
                HellSkullRender.enabled = true;
                HellSkull.transform.position = CharacterPosition;
                characterInt++;
                break;
            case 10:
                //PlayerPrefs.SetInt(selectedCharacter, 10);
                HellSkullRender.enabled = false;
                HellSkull.transform.position = OffScreen;
                SnailRender.enabled = true;
                Snail.transform.position = CharacterPosition;
                characterInt++;
                ResetInt();
                break;
            default:
                ResetInt();
                break;
        }
    }

    public void PreviousCharacter()
    {
        switch (characterInt)
        {
            case 1:
                //PlayerPrefs.SetInt(selectedCharacter, 9);
                SnailRender.enabled = false;
                Snail.transform.position = OffScreen;
                HellSkullRender.enabled = true;
                HellSkull.transform.position = CharacterPosition;
                ResetInt();
                break;
            case 2:
                //PlayerPrefs.SetInt(selectedCharacter, 10);
                TurtleRender.enabled = false;
                Turtle.transform.position = OffScreen;
                SnailRender.enabled = true;
                Snail.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 3:
                //PlayerPrefs.SetInt(selectedCharacter, 1);
                PigRender.enabled = false;
                Pig.transform.position = OffScreen;
                TurtleRender.enabled = true;
                Turtle.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 4:
                //PlayerPrefs.SetInt(selectedCharacter, 2);
                TrunkRender.enabled = false;
                Trunk.transform.position = OffScreen;
                PigRender.enabled = true;
                Pig.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 5:
                //PlayerPrefs.SetInt(selectedCharacter, 3); 
                BlueBirdRender.enabled = false;
                BlueBird.transform.position = OffScreen;
                TrunkRender.enabled = true;
                Trunk.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 6:
                //PlayerPrefs.SetInt(selectedCharacter, 4); 
                GhostRender.enabled = false;
                Ghost.transform.position = OffScreen;
                BlueBirdRender.enabled = true;
                BlueBird.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 7:
                //PlayerPrefs.SetInt(selectedCharacter, 5);
                RadishRender.enabled = false;
                Radish.transform.position = OffScreen;
                GhostRender.enabled = true;
                Ghost.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 8:
                //PlayerPrefs.SetInt(selectedCharacter, 6);
                SkullRender.enabled = false;
                Skull.transform.position = OffScreen;
                RadishRender.enabled = true;
                Radish.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 9:
                //PlayerPrefs.SetInt(selectedCharacter, 7);
                BatRender.enabled = false;
                Bat.transform.position = OffScreen;
                SkullRender.enabled = true;
                Skull.transform.position = CharacterPosition;
                characterInt--;
                break;
            case 10:
                //PlayerPrefs.SetInt(selectedCharacter, 8);
                HellSkullRender.enabled = false;
                HellSkull.transform.position = OffScreen;
                BatRender.enabled = true;
                Bat.transform.position = CharacterPosition;
                characterInt--;
                break;
            default:
                ResetInt();
                break;
        }
    }

    private void ResetInt()
    {
        if (characterInt >= 10) // количество персонажей
        {
            characterInt = 1;
        }
        else
        {
            characterInt = 10;
        }
    }
}
