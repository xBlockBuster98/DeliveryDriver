using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEvent : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("Collisione effettuata!");    
    }

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Triggered");
    }
}
