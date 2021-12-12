using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public AudioSource impactSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    
    private void OnTriggerEnter(Collider other) {
       if(other.gameObject.tag == "snowball"){
            impactSound.Play();
            Vector3 position = new Vector3(Random.Range(-2f, 14f), 2, Random.Range(-14f, 14f));
            Instantiate (gameObject , position, Quaternion.identity);
            

            Destroy(other.gameObject);
            Destroy(gameObject);
            
            ScoreScript.snowballs+=3;
           
       }
       


       
   }
}
