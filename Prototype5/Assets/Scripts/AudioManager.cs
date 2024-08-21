using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider volumeSlider;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        volumeSlider.value = 0.5f;
        audioSource.Play();

    }

    private void Update()
    {
        
        audioSource.volume = volumeSlider.value;

    }

    public void AudioController()
    {
        
    }
}
