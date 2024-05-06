using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Robot : MonoBehaviour
{
    
    
    public BoxCollider2D EndSlot;

    public Rigidbody2D Me;
    
public GameObject Spawner;

public UnityEvent Sold;



    



private void OnCollisionEnter2D(Collision2D other) {
    if(other.rigidbody == EndSlot.attachedRigidbody){
    Sold.Invoke();
    Rigidbody2D clone;
            clone = Instantiate(Me, Spawner.transform.position, Spawner.transform.rotation);
            Destroy(gameObject);
     
}
}
private void OnTriggerExit2D(Collider2D other) {
    if(other.tag != "conveyer"){
        Me.velocity = Vector2.zero;
        
}
}
}