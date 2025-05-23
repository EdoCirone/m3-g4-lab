using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mud_Ground : MonoBehaviour
{
    static float originalspeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            originalspeed = collision.GetComponent<Player_Controller>().GetSpeed();
            float speed = originalspeed;
            speed *= 0.5f;
            collision.GetComponent<Player_Controller>().SetSpeed(speed);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            collision.GetComponent<Player_Controller>().SetSpeed(originalspeed);

        }


    }


}
