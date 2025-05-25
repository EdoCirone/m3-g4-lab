using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Zombie_movement : MonoBehaviour
{

     TopDownMover _mover;
    Player_Controller _player;



    void Start()
    {
        _mover = GetComponent<TopDownMover>();
        _player = FindAnyObjectByType<Player_Controller>();
    }

    void Update()
    {
        
        
            followPlayer();
        
    }
    public void followPlayer()
    {

        _mover.Setdirection(_player.transform.position - transform.position);

    }

}
