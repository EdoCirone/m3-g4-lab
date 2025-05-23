using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{

    static int totale_Soldini = 0;

    void OnTriggerEnter2D(Collider2D other)
       
        {
            if (other.CompareTag("Player"))
            {
                totale_Soldini++;
                Debug.Log($"Ho preso un soldino, ora ho {totale_Soldini} soldini");
                Destroy(gameObject);
            }
        }

}
