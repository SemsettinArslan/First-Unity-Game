using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager Instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);

        foreach (var sound in sounds)
        {
            sound.source=gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.loop=sound.loop;
            sound.source.volume=sound.volume;
            sound.source.pitch=sound.pitch;
            sound.source.playOnAwake = false;
        }

        Instance.Play("Music");
    }
    //Audio manager eklenen sesleri oynatma ve durdurma metotlarý
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s==null)
        {
            Debug.Log("Ses" + name + " Bulunmadi");
        }
        s.source.Play();
    }
    public void Stop()
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.Log("Ses" + name + " Bulunmadi");
        }
        s.source.Stop();
    }
}
