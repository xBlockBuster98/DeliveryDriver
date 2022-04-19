using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverManager : MonoBehaviour
{
    [SerializeField] float carSpeed = 78f;
    [SerializeField] float moveSpeed = 11.2f;
    [SerializeField] float boost = 90.0f;
    [SerializeField] float slowSpeed = 20.0f;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);   
        transform.Translate(0, moveAmount, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Boost")
        {
            Debug.Log("You hitted the boost!");
            moveSpeed = boost;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;    
    }
}
