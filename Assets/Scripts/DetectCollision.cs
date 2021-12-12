using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AudioClip;

public class DetectCollision : MonoBehaviour
{  
    public AudioSource impactSound;

   private void OnTriggerEnter(Collider other) {
       if(other.gameObject.tag == "snowball"){
           impactSound.Play();
            
            Vector3 position = new Vector3(Random.Range(-14f, 14f), 0, Random.Range(-14f, 14f));
            Instantiate (gameObject , position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(gameObject);
            
        }
       


       
   }
    
}
