using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnerEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    [SerializeField] GameObject player;

    Vector2 whereToSpawn;
    private float[] spawnPoints = { -1f, -0.5f, 0f, 0.5f, 1f };
    private float timeBtwSpawn;
    private float spawnTime;

    public float timeDecrease;

    private int enemiesSpawnAmount = 1; // количество появляющихся врагов

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if ((player != null))
        {
            if (Time.timeSinceLevelLoad <= 10.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 2);
                spawnTime = 2.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 10.0f && Time.timeSinceLevelLoad < 25.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 2);
                spawnTime = 1.75f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 25.0f && Time.timeSinceLevelLoad < 40.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 1.5f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 40.0f && Time.timeSinceLevelLoad < 55.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 1.25f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 55.0f && Time.timeSinceLevelLoad < 70.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 1.15f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 70.0f && Time.timeSinceLevelLoad < 85.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 1.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 85.0f && Time.timeSinceLevelLoad < 100.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.9f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 100.0f && Time.timeSinceLevelLoad < 115.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.8f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 115.0f && Time.timeSinceLevelLoad < 135.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.7f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 135.0f && Time.timeSinceLevelLoad < 150.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.6f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 150.0f && Time.timeSinceLevelLoad < 165.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.5f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 165.0f && Time.timeSinceLevelLoad < 180.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.49f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 180.0f && Time.timeSinceLevelLoad < 195.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.48f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 195.0f && Time.timeSinceLevelLoad < 210.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.47f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 210.0f && Time.timeSinceLevelLoad < 225.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.46f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 225.0f && Time.timeSinceLevelLoad < 240.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.45f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 240.0f && Time.timeSinceLevelLoad < 255.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.44f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 255.0f && Time.timeSinceLevelLoad < 270.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.43f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 270.0f && Time.timeSinceLevelLoad < 290.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.42f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 290.0f && Time.timeSinceLevelLoad < 320.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.41f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 320.0f && Time.timeSinceLevelLoad < 360.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.4f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 360.0f && Time.timeSinceLevelLoad < 460.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.35f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 460.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.33f * timeDecrease;
            }
        }
        else
        {
            enabled = false;
        }

        if (timeBtwSpawn <= 0 && player != null)
        {
            float[] cloneSpawnPoint = spawnPoints.OrderBy(i => Random.Range(0f, 1f)).ToArray(); // создали клон массива позиций и перемешали его

            for (int i = 0; i < enemiesSpawnAmount; i++) // создание нужного кол-ва врагов
            {
                int rand = Random.Range(0, enemies.Length);

                float randomPoins = cloneSpawnPoint[i]; // Берём точки спавна по порядку, так как массив с ними уже перемешан

                whereToSpawn = new Vector2(transform.position.x, randomPoins);

                Instantiate(enemies[rand], whereToSpawn, Quaternion.identity);
            }

            timeBtwSpawn = spawnTime;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
