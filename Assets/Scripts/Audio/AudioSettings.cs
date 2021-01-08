using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider musicSlider;
    public Slider soundsSlider;

    void Start()
    {
        musicSlider.value = PlayerPrefs.GetFloat("VolumeMusic");
        soundsSlider.value = PlayerPrefs.GetFloat("VolumeSounds");

        SetVolumeMusic(PlayerPrefs.GetFloat("VolumeMusic"));
        SetVolumeSounds(PlayerPrefs.GetFloat("VolumeSounds"));
    }

    public void SetVolumeMusic(float volume)
    {
        audioMixer.SetFloat("volumeMusic", volume);
        PlayerPrefs.SetFloat("VolumeMusic", volume);
        PlayerPrefs.Save();
    }
    public void SetVolumeSounds(float volume)
    {
        audioMixer.SetFloat("volumeSounds", volume);
        PlayerPrefs.SetFloat("VolumeSounds", volume);
        PlayerPrefs.Save();
    }
}
