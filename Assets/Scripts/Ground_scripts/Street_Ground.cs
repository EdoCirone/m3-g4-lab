using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Street_Ground : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

          

        if (collision.CompareTag("Player") )
        {
            TopDownMover mover = collision.GetComponent<TopDownMover>();
            if (mover != null && !mover.IsBoosted())
            {

            float speed = mover.GetSpeed();
            speed *= 2f;
            mover.SetSpeed(speed);


            }
 


        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        

        if (collision.CompareTag("Player"))
        {
            TopDownMover mover = collision.GetComponent<TopDownMover>();

            if (mover != null )
            {

                mover.ResetSpeed(); 
                           
            }



        }
    }

}
