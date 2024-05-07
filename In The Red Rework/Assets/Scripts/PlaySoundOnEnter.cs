using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnter : MonoBehaviour
{
    AudioSource source;
    Collider2D SoundTrigger;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        SoundTrigger = GetComponent<Collider2D>();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        source.Play();
    }
}