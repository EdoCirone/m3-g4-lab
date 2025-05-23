using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] int hlt = 10;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Life_Controller playerlife = collision.GetComponent<Life_Controller>();
            playerlife.TakeHealt(hlt);

        }
    }
}
