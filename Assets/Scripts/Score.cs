using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    [SerializeField] GameObject player;
    private int scoreInt;
    public string scoreLevel;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        score.text = (Time.timeSinceLevelLoad / 2.0).ToString("0");
        scoreInt = int.Parse(score.text);
        PlayerPrefs.SetInt(scoreLevel, scoreInt);

        if (player.GetComponent<PlayerController>().health <= 0)
        {
            enabled = false;
        }
    }
}
