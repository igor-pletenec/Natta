using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLast : MonoBehaviour
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
            if (Time.timeSinceLevelLoad <= 8.0f)
            {
                enemySpeed = 1.0f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 8.0f && Time.timeSinceLevelLoad < 22.0f)
            {
                enemySpeed = 1.25f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 22.0f && Time.timeSinceLevelLoad < 32.0f)
            {
                enemySpeed = 1.3f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 32.0f && Time.timeSinceLevelLoad < 42.0f)
            {
                enemySpeed = 1.4f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 42.0f && Time.timeSinceLevelLoad < 70.0f)
            {
                enemySpeed = 0.7f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 70.0f && Time.timeSinceLevelLoad < 88.0f)
            {
                enemySpeed = 1.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 88.0f && Time.timeSinceLevelLoad < 135.0f)
            {
                enemySpeed = 0.8f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 135.0f && Time.timeSinceLevelLoad < 146.0f)
            {
                enemySpeed = 1.5f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 146.0f && Time.timeSinceLevelLoad < 162.0f)
            {
                enemySpeed = 1.6f * speedGrowth;
            }
            else if (Time.timeSinceLevelLoad > 162.0f && Time.timeSinceLevelLoad < 182.0f)
            {
                enemySpeed = 1.8f * speedGrowth;
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
