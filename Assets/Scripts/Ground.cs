using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject deathMenu;
    [SerializeField] GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (player.GetComponent<PlayerController>().health <= 0)
        {
            deathMenu.SetActive(true);
            enabled = false;
        }
    } 
}
