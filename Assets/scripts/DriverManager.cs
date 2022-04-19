using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverManager : MonoBehaviour
{
    [SerializeField] float carSpeed = 78f;
    [SerializeField] float moveSpeed = 11.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);   
        transform.Translate(0, moveAmount, 0);
    }
}
