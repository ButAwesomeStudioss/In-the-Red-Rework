using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SearchService;
using UnityEngine;

public class Spawner : MonoBehaviour

{
public Rigidbody2D solder;

    void Start()
    {
  
    }

    



    void Update()
    {
        if (solder == null)
        {
        Debug.Log(":)");
            Rigidbody2D clone;
            clone = Instantiate(solder, transform.position, transform.rotation);

    
        }
    }
}
