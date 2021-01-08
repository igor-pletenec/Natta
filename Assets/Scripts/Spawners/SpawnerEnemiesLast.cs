using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class SpawnerEnemiesLast : MonoBehaviour
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
            if (Time.timeSinceLevelLoad <= 8.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 2);
                spawnTime = 2.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 8.0f && Time.timeSinceLevelLoad < 22.0f)
            {
                enemiesSpawnAmount = Random.Range(3, 4);
                spawnTime = 1.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 22.0f && Time.timeSinceLevelLoad < 32.0f)
            {
                enemiesSpawnAmount = Random.Range(2, 3);
                spawnTime = 0.8f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 32.0f && Time.timeSinceLevelLoad < 42.0f)
            {
                enemiesSpawnAmount = Random.Range(3, 4);
                spawnTime = 0.6f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 42.0f && Time.timeSinceLevelLoad < 70.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 1.0f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 70.0f && Time.timeSinceLevelLoad < 88.0f)
            {
                enemiesSpawnAmount = Random.Range(2, 3);
                spawnTime = 0.6f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 88.0f && Time.timeSinceLevelLoad < 135.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.8f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 135.0f && Time.timeSinceLevelLoad < 146.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.55f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 146.0f && Time.timeSinceLevelLoad < 162.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 3);
                spawnTime = 0.45f * timeDecrease;
            }
            else if (Time.timeSinceLevelLoad > 162.0f && Time.timeSinceLevelLoad < 182.0f)
            {
                enemiesSpawnAmount = Random.Range(1, 2);
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
