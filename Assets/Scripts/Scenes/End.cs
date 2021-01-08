using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject endEffect;

    private void Update()
    {
        transform.Translate(Vector2.left * 1.4f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerController>().health -= 100;
            Instantiate(endEffect, transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("End", 1);
            Destroy(gameObject);
        }
    }
}
