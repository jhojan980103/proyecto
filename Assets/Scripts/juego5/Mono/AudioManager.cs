﻿using System;
using UnityEngine;

[System.Serializable()]
public struct SoundParameters
{
    [Range(0, 1)]
    public float Volume;
    [Range(-3, 3)]
    public float Pitch;
    public bool Loop;
}
[System.Serializable()]
public class Sound
{
    #region Variables

    [SerializeField] String name = String.Empty;
    public String Name {get{return name;}}

    [SerializeField] AudioClip clip = null;
    public AudioClip Clip {get{return clip;}}

    [SerializeField] SoundParameters parameters = new SoundParameters();
    public SoundParameters Parameters {get{return parameters;}}

    [HideInInspector]
    public AudioSource Source = null;

    #endregion

    public void Play ()
    {
        Source.clip = Clip;

        Source.volume = Parameters.Volume;
        Source.pitch = Parameters.Pitch;
        Source.loop = Parameters.Loop;

        Source.Play();
    }
    public void Stop ()
    {
        Source.Stop();
    }
}
public class AudioManager : MonoBehaviour {

    #region Variables

    public static AudioManager Instance = null;

    [SerializeField] Sound[] sounds = null;
    [SerializeField] AudioSource sourcePrefab = null;

    [SerializeField] String startupTrack = String.Empty;

    #endregion

    #region Default Unity methods

    
    /// Función a la que se llama en el marco cuando se habilita un script justo antes de que se llame por primera vez a cualquiera de los métodos de actualización.
    
    void Awake()
    {
        if (Instance != null)
        { Destroy(gameObject); }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        InitSounds();
    }
    
    /// Función a la que se llama cuando se carga la instancia de script.
    
    void Start()
    {
        if (string.IsNullOrEmpty(startupTrack) != true)
        {
            PlaySound(startupTrack);
        }
    }

    #endregion

    
    /// Función a la que se llama para inicializar sonidos.
    
    void InitSounds()
    {
        foreach (var sound in sounds)
        {
            AudioSource source = (AudioSource)Instantiate(sourcePrefab, gameObject.transform);
            source.name = sound.Name;

            sound.Source = source;
        }
    }

    
    /// Función que se llama para reproducir un sonido.
    
    public void PlaySound(string name)
    {
        var sound = GetSound(name);
        if (sound != null)
        {
            sound.Play();
        }
        else
        {
            Debug.LogWarning("Sonido por el nombre " + name + " ¡no se encuentra! ");
        }
    }
    
    /// Función que se llama para detener la reproducción de un sonido.
    
    public void StopSound(string name)
    {
        var sound = GetSound(name);
        if (sound != null)
        {
            sound.Stop();
        }
        else
        {
            Debug.LogWarning("Sonido por el nombre " + name + " ¡no se encuentra! ");
        }
    }

    #region Getters

    Sound GetSound(string name)
    {
        foreach (var sound in sounds)
        {
            if (sound.Name == name)
            {
                return sound;
            }
        }
        return null;
    }

    #endregion
}