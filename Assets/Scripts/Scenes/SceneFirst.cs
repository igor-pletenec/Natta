using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneFirst : MonoBehaviour
{
    public float timeOfScene;

    void Start()
    {
        Invoke("Play", timeOfScene);
    }

    void Play()
    {
        SceneManager.LoadScene("Menu");
    }
}
