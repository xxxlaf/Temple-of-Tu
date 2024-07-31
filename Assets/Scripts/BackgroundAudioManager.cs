using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField]
    AudioSource MusicSource;

    [Header("Audio Clips")]
    [SerializeField]
    AudioClip BackgroundMusic;

    public static BackgroundAudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        MusicSource.clip = BackgroundMusic;
        MusicSource.Play();
    }
}
