using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Audio
{
    [SerializeField] private string name;
    [SerializeField] private AudioClip audioClip;

    public string Name => name;
    public AudioClip AudioClip => audioClip;
}

public class AudioManager : Singletone<AudioManager>
{
    [Header("Audio")]
    [SerializeField] private Audio[] audios;
    [SerializeField] private AudioSource audioSource;

    public override void OnAwake()
    {
        Instance = this;
    }

    public void Play(string name)
    {
        audioSource.PlayOneShot(Array.Find(audios, n => n.Name == name).AudioClip);
    }
}
