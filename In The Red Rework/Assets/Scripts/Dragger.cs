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
    
    private bool dragging;
    
    private Vector2 offset;
    
    public BoxCollider2D EndSlot;

    public BoxCollider2D Me;

public int destroy = 0;
    void Update() {
if(!dragging) return;
    
 var mousePosition = GetMousePos();

 transform.position = mousePosition - offset;
    
    
    }
   
    void OnMouseDown () {
dragging = true;
offset = GetMousePos() - (Vector2)transform.position;
}
void OnCollisionEnter2D(Collision2D col)
{
if (col.gameObject.tag == "Hazard")
{
Destroy(Me);
}
}

void OnMouseUp(){

   
    

        transform.position = transform.position;
dragging = false;
    
}
Vector2 GetMousePos(){
return Camera.main.ScreenToWorldPoint(Input.mousePosition);
}



}
