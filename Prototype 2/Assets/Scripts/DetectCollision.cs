using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //overide a model behavior method
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);  // destroy the pizza
        Destroy(other.gameObject); // destroy the object collided with 
    }
}
