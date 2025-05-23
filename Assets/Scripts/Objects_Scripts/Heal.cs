using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] int hlt = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            Life_Controller playerlife = other.GetComponent<Life_Controller>();
            
            if ( playerlife.CurrentHealth < playerlife.MaxHealth )
            {

                playerlife.TakeHeal(hlt);
                Destroy(gameObject);

            }
            

        }
    }
}
