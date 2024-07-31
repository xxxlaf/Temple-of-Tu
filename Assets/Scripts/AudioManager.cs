using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField]
    AudioSource SFXSource;

    [Header("Audio Clips")]
    [SerializeField]
    AudioClip Click;
    [SerializeField]
    AudioClip SymbolClick;
    [SerializeField]
    AudioClip PuzzleSuccess;
    [SerializeField]
    AudioClip FailedNoise;
    [SerializeField]
    AudioClip SymbolSwitch;
    [SerializeField]
    List<AudioClip> RockNoises;

    public static AudioManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayClickNoise()
    {
        SFXSource.clip = Click;
        SFXSource.Play();
    }

    public void PlaySymbolClickNoise()
    {
        SFXSource.clip = SymbolClick;
        SFXSource.Play();
    }

    public void PlayPuzzleSuccessNoise()
    {
        SFXSource.clip = PuzzleSuccess;
        SFXSource.Play();
    }

    public void PlayFailedNoise()
    {
        SFXSource.clip = FailedNoise;
        SFXSource.Play();
    }

    public void PlaySymbolSwitch()
    {
        SFXSource.clip = SymbolSwitch;
        SFXSource.Play();
    }

    public void PlayRockNoise()
    {
        System.Random rnd = new System.Random();

        int num = rnd.Next(0, RockNoises.Count);

        SFXSource.clip = RockNoises[num];
        SFXSource.Play();
    }
}
