using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour

{
public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space")){
GameObject clone;
            clone = Instantiate(ball, gameObject.transform.position, gameObject.transform.rotation);
        }

    }

}

