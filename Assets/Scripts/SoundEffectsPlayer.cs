using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource source;
    public AudioClip onEnter;

    public void Start()
    {
        PlaySound(onEnter);
    }

    public void PlaySound(AudioClip audioClip)
    {
        source.clip = audioClip;
        source.Play();
    }
}
