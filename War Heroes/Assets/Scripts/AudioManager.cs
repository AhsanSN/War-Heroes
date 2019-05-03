using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;
    public static AudioManager instance;
    public Sound[] sounds;

    public float MasterVolume;

    // Start is called before the first frame update
    void Awake()
    {/*
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        */

        //DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = (s.volume)*MasterVolume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.channel.audioMixer.outputAudioMixerGroup = mixer.outputAudioMixerGroup;
        }
    }

    // Update is called once per frame
    public void play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("sound " + name + " not found");
            return;
        }
        s.source.Play();
    }


    void Start()
    {
        play("Battle Music");
    }

    public void SetVolume(float value)
    {
        MasterVolume = value;
        foreach (Sound s in sounds)
        {
            s.source.volume = (s.volume) * MasterVolume;
        }
    }
}