using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public GameObject finishEffect;

    private void Update()
    {
        transform.Translate(Vector2.left * 1.4f * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(finishEffect, transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("ShoweFirst", 1);
            Invoke("LoadNewScene", 1.5f);
        }
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene("Menu");
    }
}
