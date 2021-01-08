using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timer;

    void Update()
    {
        timer.text = ((int)Time.timeSinceLevelLoad).ToString();
    }
}
