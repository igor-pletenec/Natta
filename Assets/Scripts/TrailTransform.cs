using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailTransform : MonoBehaviour
{
    public GameObject trail;

    private void Awake()
    {
        trail = GameObject.FindGameObjectWithTag("Trail");
        trail.transform.parent = transform;
    }
}
