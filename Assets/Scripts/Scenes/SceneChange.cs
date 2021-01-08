using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public float timeOfScene;

    void Start()
    {
        Invoke("Play", timeOfScene);
    }

    void Play()
    {
        if (PlayerPrefs.GetInt("ShoweFirst", 0) == 0)
        {
            SceneManager.LoadScene("First");
            PlayerPrefs.SetFloat("VolumeMusic", -15.0f);
            PlayerPrefs.SetFloat("VolumeSounds", -15.0f);
            // PlayerPrefs.SetInt("ShoweFirst", 1); 
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
