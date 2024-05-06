using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    AudioSource source;
    Collider2D SoundTriggerOnEnter;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        SoundTriggerOnEnter = GetComponent<Collider2D>();
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        source.Play();
    }
}