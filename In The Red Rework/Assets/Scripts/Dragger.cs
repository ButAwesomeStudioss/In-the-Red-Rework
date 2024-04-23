using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Dragger : MonoBehaviour
{
    
    private bool dragging;
    
    private Vector2 offset;
    
    public BoxCollider2D EndSlot;

    public Rigidbody2D Me;
    public GameObject tile;
public GameObject Spawner;
public int Value;
 
    

    void Update() {
if(!dragging) return;
    
 var mousePosition = GetMousePos();

 transform.position = mousePosition - offset;
    
    
    }
   
    void OnMouseDown () {
dragging = true;
offset = GetMousePos() - (Vector2)transform.position;
}



void OnMouseUp(){
transform.position = transform.position;
dragging = false;

}

Vector2 GetMousePos(){
return Camera.main.ScreenToWorldPoint(Input.mousePosition);
}
private void OnCollisionEnter2D(Collision2D other) {
    Rigidbody2D clone;
            clone = Instantiate(Me, Spawner.transform.position, Spawner.transform.rotation);
            Destroy(gameObject);
            
            
            

}

            
            

}
        



