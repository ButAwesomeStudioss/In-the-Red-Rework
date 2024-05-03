using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Dragger : MonoBehaviour
{

    void Awake()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseOver() {


        if (Input.GetMouseButtonDown(0))
        {
 transform.Rotate(0,0,90);
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
        }
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
   


    }

internal class MyClass
{
    public MyClass()
    {
    }

    internal void AudioSource()
    {
        throw new NotImplementedException();
    }
}