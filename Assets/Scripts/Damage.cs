using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int damageAmount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "level2"){
            Debug.Log("I have a collision with player!");
            Destroy(gameObject);
            Health _health = other.gameObject.GetComponent<Health>();
            if (_health != null){
                _health.TakeDamage(damageAmount);
            }
        }
        
    }
}
