using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerLast : MonoBehaviour
{
    public GameObject end;

    void Update()
    {
        int i = 0;

        if (Time.timeSinceLevelLoad >= 180.0f)
        {
            i++;
            Instantiate(end, transform.position, Quaternion.identity);
        }

        if (i == 1)
        {
            enabled = false;
        }
    }
}
