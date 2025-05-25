using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_Attack : MonoBehaviour
{
    [SerializeField] int dmg = 2;


    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Life_Controller _playerlife = collision.collider.GetComponent<Life_Controller>();

            _playerlife.TakeDamage(dmg);


        }
    }
}
