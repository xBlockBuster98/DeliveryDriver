using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(0, 1, 12, 1);
    [SerializeField] Color32 noPackageColor = new Color32(0, 1, 12, 1);
    [SerializeField] float destroyDelay = 0.2f;
    bool hasPackage = false;
    SpriteRenderer spriteRenderer;

    private void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        //checking if the tag is "Package"
        if(other.tag == "Package" && !hasPackage) 
        {
            Debug.Log("package picked up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destroyDelay);
        } else if(other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Customer triggered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
