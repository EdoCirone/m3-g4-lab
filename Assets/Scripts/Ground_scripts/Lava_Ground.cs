using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava_Ground : MonoBehaviour
{
    int dmg = 2;
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Life_Controller playerlife = collision.GetComponent<Life_Controller>();
            playerlife.TakeDamage(dmg);
            Debug.Log($"sto sulla lava!! ho subito {dmg} danni");

        }
    }


}
