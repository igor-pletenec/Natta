using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerCoinLast : MonoBehaviour
{
    public GameObject[] coins;
    [SerializeField] GameObject player;

    Vector2 whereToSpawn;
    float[] spawnPoints = { -1f, -0.5f, 0f, 0.5f, 1f };

    private float timeBtwSpawn;
    private float spawnTime;

    public float timeDecrease;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if ((player != null))
        {
            if (Time.timeSinceLevelLoad <= 8.0f)
            {
                spawnTime = 2.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 8.0f && Time.timeSinceLevelLoad < 22.0f)
            {
                spawnTime = 1.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 22.0f && Time.timeSinceLevelLoad < 32.0f)
            {
                spawnTime = 0.8f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 32.0f && Time.timeSinceLevelLoad < 42.0f)
            {
                spawnTime = 0.6f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 42.0f && Time.timeSinceLevelLoad < 70.0f)
            {
                spawnTime = 1.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 70.0f && Time.timeSinceLevelLoad < 88.0f)
            {
                spawnTime = 0.6f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 88.0f && Time.timeSinceLevelLoad < 135.0f)
            {
                spawnTime = 0.8f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 135.0f && Time.timeSinceLevelLoad < 146.0f)
            {
                spawnTime = 0.55f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 146.0f && Time.timeSinceLevelLoad < 162.0f)
            {
                spawnTime = 0.45f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 162.0f && Time.timeSinceLevelLoad < 182.0f)
            {
                spawnTime = 0.65f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 182.0f)
            {
                enabled = false;
            }
        }
        else
        {
            enabled = false;
        }


        if (timeBtwSpawn <= 0 && player != null)
        {
            if (Time.timeSinceLevelLoad < 60)
            {
                int rand = Random.Range(0, coins.Length);

                float randomPoins = spawnPoints[Random.Range(0, spawnPoints.Length)];

                whereToSpawn = new Vector2(transform.position.x, randomPoins);

                Instantiate(coins[rand], whereToSpawn, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 60 && Time.timeSinceLevelLoad < 120)
            {
                int rand = Random.Range(0, coins.Length - 1);

                float randomPoins = spawnPoints[Random.Range(0, spawnPoints.Length)];

                whereToSpawn = new Vector2(transform.position.x, randomPoins);

                Instantiate(coins[rand], whereToSpawn, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 120 && Time.timeSinceLevelLoad < 180)
            {
                int rand = Random.Range(0, coins.Length - 2);

                float randomPoins = spawnPoints[Random.Range(0, spawnPoints.Length)];

                whereToSpawn = new Vector2(transform.position.x, randomPoins);

                Instantiate(coins[rand], whereToSpawn, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 180 && Time.timeSinceLevelLoad < 360)
            {
                int rand = Random.Range(0, coins.Length - 3);

                float randomPoins = spawnPoints[Random.Range(0, spawnPoints.Length)];

                whereToSpawn = new Vector2(transform.position.x, randomPoins);

                Instantiate(coins[rand], whereToSpawn, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 360)
            {
                int rand = Random.Range(0, coins.Length - 4);

                float randomPoins = spawnPoints[Random.Range(0, spawnPoints.Length)];

                whereToSpawn = new Vector2(transform.position.x, randomPoins);

                Instantiate(coins[rand], whereToSpawn, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
