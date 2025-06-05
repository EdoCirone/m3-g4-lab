using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botton_Scripts : MonoBehaviour
{
    [SerializeField] Collider2D _door;
    Collider2D _rock;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Rock"))
        {

            _door.isTrigger = true;

        }

    }

}
