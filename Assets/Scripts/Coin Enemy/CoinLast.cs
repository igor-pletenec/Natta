using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinLast : MonoBehaviour
{
    public GameObject coinEffect;
    private GameObject player;

    private float coinSpeed;
    public float speedGrowth;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.Translate(Vector2.left * coinSpeed * Time.deltaTime);

        if ((player != null))
        {
            if (Time.timeSinceLevelLoad <= 8.0f)
            {
                coinSpeed = 1.0f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 8.0f && Time.timeSinceLevelLoad < 22.0f)
            {
                coinSpeed = 1.25f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 22.0f && Time.timeSinceLevelLoad < 32.0f)
            {
                coinSpeed = 1.3f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 32.0f && Time.timeSinceLevelLoad < 42.0f)
            {
                coinSpeed = 1.4f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 42.0f && Time.timeSinceLevelLoad < 70.0f)
            {
                coinSpeed = 0.7f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 70.0f && Time.timeSinceLevelLoad < 88.0f)
            {
                coinSpeed = 1.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 88.0f && Time.timeSinceLevelLoad < 135.0f)
            {
                coinSpeed = 0.8f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 135.0f && Time.timeSinceLevelLoad < 146.0f)
            {
                coinSpeed = 1.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 146.0f && Time.timeSinceLevelLoad < 162.0f)
            {
                coinSpeed = 1.6f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 162.0f && Time.timeSinceLevelLoad < 182.0f)
            {
                coinSpeed = 1.8f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 182.0f)
            {
                Destroy(gameObject);
            }
        }
        else
        {
            enabled = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Wall") || other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
