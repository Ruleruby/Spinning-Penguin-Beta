using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public AudioSource impactSound;
    public int maxHealth = 2;
    public int currentHealth;
    public bool alive = true;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(int damageAmount){
        if(currentHealth <= 1){
            alive = false;
            currentHealth -= damageAmount;
            impactSound.Play();
            // currentHealth = null;
            Vector3 position = new Vector3(Random.Range(-14f, 14f), 2, Random.Range(-14f, 14f));
            Instantiate (gameObject, position, Quaternion.identity);
            Destroy(this.gameObject);
            ScoreCounter.Counter++;
            ScoreScript.snowballs+=5;
        }
        else{
            alive = true;
            currentHealth -= damageAmount;
            impactSound.Play();
        }
    }
}
