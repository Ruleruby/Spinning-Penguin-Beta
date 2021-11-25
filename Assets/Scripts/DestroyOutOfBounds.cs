using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 15;
    private float lowBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < lowBound){
            Destroy(gameObject);
        }   
        if(transform.position.x > topBound || transform.position.x < lowBound){
            Destroy(gameObject);
        }   
    }
}
