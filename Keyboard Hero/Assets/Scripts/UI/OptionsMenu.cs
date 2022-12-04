using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public AudioSource audioSource;
    [SerializeField] private AudioMixer myAudioMixer;

private void Start() {
    

    audioSource.volume = PlayerPrefs.GetFloat("MasterVolume",audioSource.volume);
}
    public void SetVolume(float sliderValue)
    {
        PlayerPrefs.SetFloat("MasterVolume",sliderValue);
        myAudioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);
    }
    
    public void FullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
