using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Object
{
    [SerializeField] int hlt = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Life_Controller playerlife = other.GetComponent<Life_Controller>();
            playerlife.TakeHeal(hlt);

            if ( playerlife.CurrentHealth < playerlife.MaxHealth )
            {
                Destroy(gameObject);
            }
 

        }
    }
}
