using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_Ground : MonoBehaviour
{
     static float originalSpeed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ( "Player" ))
        {
            originalSpeed = collision.GetComponent<Player_Controller>().GetSpeed(); 
           float speed =  originalSpeed;
            speed *= 2f;
            collision.GetComponent<Player_Controller>().SetSpeed(speed);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag ( "Player" ))
        {

            collision.GetComponent<Player_Controller>().SetSpeed(originalSpeed);
        }
    }

}
