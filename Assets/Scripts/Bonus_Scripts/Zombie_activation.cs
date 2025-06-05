using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie_activation : MonoBehaviour
{
    GameObject[] zombies;
    bool inMovement = false;

    private void Start()
    {
        zombies = GameObject.FindGameObjectsWithTag("Zombie");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inMovement = !inMovement;

            foreach (GameObject zombie in zombies)
            {

                TopDownMover mov = zombie.GetComponent<TopDownMover>();

                if (mov != null)
                {

                    mov.enabled = inMovement;

                }


            } 
        }

    }
}
