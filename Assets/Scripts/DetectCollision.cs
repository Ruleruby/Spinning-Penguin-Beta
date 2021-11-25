using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // [SerializeField]
    // public GameObject IceCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other) {
       if(other.gameObject.tag == "fish"){
            Destroy(other.gameObject);
            Destroy(gameObject);
            Vector3 position = new Vector3(Random.Range(-14f, 14f), 0, Random.Range(-14f, 14f));
            Instantiate (gameObject, position, Quaternion.identity);
        
       }
   }
    
}
