using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject effect;
    private GameObject player;

    private int damage = 1;

    private float enemySpeed;
    public float speedGrowth;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        transform.Translate(Vector2.left * enemySpeed * Time.deltaTime);

        if ((player != null))
        {
            if (Time.timeSinceLevelLoad <= 10.0f)
            {
                enemySpeed = 1.4f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 10.0f && Time.timeSinceLevelLoad < 25.0f)
            {
                enemySpeed = 1.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 25.0f && Time.timeSinceLevelLoad < 40.0f)
            {
                enemySpeed = 1.6f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 40.0f && Time.timeSinceLevelLoad < 55.0f)
            {
                enemySpeed = 1.75f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 55.0f && Time.timeSinceLevelLoad < 70.0f)
            {
                enemySpeed = 2.0f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 70.0f && Time.timeSinceLevelLoad < 85.0f)
            {
                enemySpeed = 2.25f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 85.0f && Time.timeSinceLevelLoad < 100.0f)
            {
                enemySpeed = 2.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 100.0f && Time.timeSinceLevelLoad < 115.0f)
            {
                enemySpeed = 2.75f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 115.0f && Time.timeSinceLevelLoad < 135.0f)
            {
                enemySpeed = 3.0f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 135.0f && Time.timeSinceLevelLoad < 150.0f)
            {
                enemySpeed = 3.25f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 150.0f && Time.timeSinceLevelLoad < 165.0f)
            {
                enemySpeed = 3.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 165.0f && Time.timeSinceLevelLoad < 180.0f)
            {
                enemySpeed = 3.75f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 180.0f && Time.timeSinceLevelLoad < 195.0f)
            {
                enemySpeed = 4.0f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 195.0f && Time.timeSinceLevelLoad < 210.0f)
            {
                enemySpeed = 4.1f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 210.0f && Time.timeSinceLevelLoad < 225.0f)
            {
                enemySpeed = 4.2f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 225.0f && Time.timeSinceLevelLoad < 240.0f)
            {
                enemySpeed = 4.3f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 240.0f && Time.timeSinceLevelLoad < 255.0f)
            {
                enemySpeed = 4.4f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 255.0f && Time.timeSinceLevelLoad < 270.0f)
            {
                enemySpeed = 4.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 270.0f && Time.timeSinceLevelLoad < 290.0f)
            {
                enemySpeed = 4.6f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 290.0f && Time.timeSinceLevelLoad < 320.0f)
            {
                enemySpeed = 4.7f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 320.0f && Time.timeSinceLevelLoad < 360.0f)
            {
                enemySpeed = 4.8f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 360.0f && Time.timeSinceLevelLoad < 460.0f)
            {
                enemySpeed = 5.0f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 460.0f)
            {
                enemySpeed = 5.5f * speedGrowth;
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
            Instantiate(effect, transform.position, Quaternion.identity);
            other.GetComponent<PlayerController>().health -= damage;
            Destroy(gameObject);
        }
        else if (other.CompareTag("Wall"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Shield"))
        {
            damage = 0;
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else
        {
            damage = 1;
        }
    }
}
