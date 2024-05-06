using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dragger : MonoBehaviour
{
public UnityEvent SoldConveyer;

    
    
    private void OnMouseOver() {
            
   
 if(Input.GetMouseButtonDown(0)){
 transform.Rotate(0,0,90);

}
        if (Input.GetMouseButtonDown(1))
        {
            
            SoldConveyer.Invoke();
            Destroy(gameObject);

        }
    }
   


    }

    
            
     
      



    

    




            



            
            



        



