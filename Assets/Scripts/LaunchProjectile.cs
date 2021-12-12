using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchProjectile : MonoBehaviour
{
    public GameObject projectile;
    public float launch = 800f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            GameObject fish = Instantiate(projectile, transform.position, 
                                                     transform.rotation);
            fish.GetComponent<Rigidbody>().AddRelativeForce(new Vector3 
                                                (launch, 0,0));
        }
    }
}
