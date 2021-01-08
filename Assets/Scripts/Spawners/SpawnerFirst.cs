using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnerFirst : MonoBehaviour
{
    public GameObject[] spawnObjects;
    public GameObject player;
    public GameObject arrow;

    private float timeBtwSpawn;
    private float spawnTime = 5.0f;

    void Start()
    {
        arrow.SetActive(false);
    }

    void Update()
    {
        if (player.GetComponent<PlayerController>().health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (timeBtwSpawn <= 0f)
        {
            if (Time.timeSinceLevelLoad < 4.0f)
            {
                Instantiate(spawnObjects[0], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 4.0f && Time.timeSinceLevelLoad < 9.0f)
            {
                Instantiate(spawnObjects[1], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 9.0f && Time.timeSinceLevelLoad < 14.0f)
            {
                Instantiate(spawnObjects[2], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 14.0f && Time.timeSinceLevelLoad < 19.0f)
            {
                Instantiate(spawnObjects[3], transform.position, Quaternion.identity);
                arrow.SetActive(true);
                timeBtwSpawn = spawnTime;
            }
            else if (Time.timeSinceLevelLoad > 19.0f && Time.timeSinceLevelLoad < 22.0f)
            {
                Instantiate(spawnObjects[4], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
                spawnTime = 3.0f;
                arrow.SetActive(false);
            }
            else if (Time.timeSinceLevelLoad > 22.0f && Time.timeSinceLevelLoad < 25.0f)
            {
                Instantiate(spawnObjects[5], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
                spawnTime = 3.0f;
            }
            else if (Time.timeSinceLevelLoad > 25.0f && Time.timeSinceLevelLoad < 28.0f)
            {
                Instantiate(spawnObjects[6], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
                spawnTime = 3.0f;
            }
            else if (Time.timeSinceLevelLoad > 28.0f && Time.timeSinceLevelLoad < 30.0f)
            {
                Instantiate(spawnObjects[7], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
                spawnTime = 5.0f;
            }
            else if (Time.timeSinceLevelLoad > 30.0f)
            {
                Instantiate(spawnObjects[8], transform.position, Quaternion.identity);
                timeBtwSpawn = spawnTime;
                spawnTime = 10.0f;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
