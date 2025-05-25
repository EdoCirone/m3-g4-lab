using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : Object
{
    [SerializeField] int dmg = 10;
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Life_Controller playerlife = collision.GetComponent<Life_Controller>();
            playerlife.TakeDamage( dmg);
            Destroy(gameObject);

        }
    }

}
