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
    
    private void OnMouseOver() {
            
   
 if(Input.GetMouseButtonDown(0)){
 transform.Rotate(0,0,90);

}
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
   


    }

    
            
     
      



    

    




            



            
            



        



