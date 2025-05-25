using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holy_Gorund : MonoBehaviour
{

    [SerializeField] int hlt = 2;

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            Life_Controller playerlife = collision.GetComponent<Life_Controller>();

            Debug.Log($"Sto su suolo sacro mi sono curato di {hlt}");

            playerlife.TakeHeal(hlt);


        }

    }

}
