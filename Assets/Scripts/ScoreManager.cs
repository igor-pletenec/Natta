using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int scoreValue1;
    private int scoreValue2;
    private int scoreValue3;
    private int scoreValue4;
    private int scoreValue5;
    private int scoreValue6;
    private int scoreValue7;
    private int scoreValue8;
    private int scoreValue9;
    private int scoreValue10;

    private int maxScoreValue1;
    private int maxScoreValue2;
    private int maxScoreValue3;
    private int maxScoreValue4;
    private int maxScoreValue5;
    private int maxScoreValue6;
    private int maxScoreValue7;
    private int maxScoreValue8;
    private int maxScoreValue9;
    private int maxScoreValue10;

    private void Start()
    {
        scoreValue1 = PlayerPrefs.GetInt("Score1");
        scoreValue2 = PlayerPrefs.GetInt("Score2");
        scoreValue3 = PlayerPrefs.GetInt("Score3");
        scoreValue4 = PlayerPrefs.GetInt("Score4");
        scoreValue5 = PlayerPrefs.GetInt("Score5");
        scoreValue6 = PlayerPrefs.GetInt("Score6");
        scoreValue7 = PlayerPrefs.GetInt("Score7");
        scoreValue8 = PlayerPrefs.GetInt("Score8");
        scoreValue9 = PlayerPrefs.GetInt("Score9");
        scoreValue10 = PlayerPrefs.GetInt("Score10");

        maxScoreValue1 = PlayerPrefs.GetInt("maxScore1");
        maxScoreValue2 = PlayerPrefs.GetInt("maxScore2");
        maxScoreValue3 = PlayerPrefs.GetInt("maxScore3");
        maxScoreValue4 = PlayerPrefs.GetInt("maxScore4");
        maxScoreValue5 = PlayerPrefs.GetInt("maxScore5");
        maxScoreValue6 = PlayerPrefs.GetInt("maxScore6");
        maxScoreValue7 = PlayerPrefs.GetInt("maxScore7");
        maxScoreValue8 = PlayerPrefs.GetInt("maxScore8");
        maxScoreValue9 = PlayerPrefs.GetInt("maxScore9");
        maxScoreValue10 = PlayerPrefs.GetInt("maxScore10");

        if (scoreValue1 > maxScoreValue1)
        {
            PlayerPrefs.SetInt("maxScore1", scoreValue1);
        }

        if (scoreValue2 > maxScoreValue2)
        {
            PlayerPrefs.SetInt("maxScore2", scoreValue2);
        }

        if (scoreValue3 > maxScoreValue3)
        {
            PlayerPrefs.SetInt("maxScore3", scoreValue3);
        }

        if (scoreValue4 > maxScoreValue4)
        {
            PlayerPrefs.SetInt("maxScore4", scoreValue4);
        }

        if (scoreValue5 > maxScoreValue5)
        {
            PlayerPrefs.SetInt("maxScore5", scoreValue5);
        }

        if (scoreValue6 > maxScoreValue6)
        {
            PlayerPrefs.SetInt("maxScore6", scoreValue6);
        }

        if (scoreValue7 > maxScoreValue7)
        {
            PlayerPrefs.SetInt("maxScore7", scoreValue7);
        }

        if (scoreValue8 > maxScoreValue8)
        {
            PlayerPrefs.SetInt("maxScore8", scoreValue8);
        }

        if (scoreValue9 > maxScoreValue9)
        {
            PlayerPrefs.SetInt("maxScore9", scoreValue9);
        }

        if (scoreValue10 > maxScoreValue10)
        {
            PlayerPrefs.SetInt("maxScore10", scoreValue10);
        }
    }
}
