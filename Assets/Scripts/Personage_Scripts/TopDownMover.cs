using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class TopDownMover : MonoBehaviour
{

    Rigidbody2D _rb;
    float originalSpeed;
    bool isBoosted = false;

    [SerializeField] float speed = 2;

    Vector2 _dir;

    public float GetSpeed() {  return speed; }


    public void SetSpeed(float speed)
    {
    
        this.speed = speed;
        isBoosted = true;

    }

    
    public void ResetSpeed()
    {
        speed = originalSpeed;
        isBoosted = false;
    }
    public bool IsBoosted() => isBoosted;

    public void Setdirection(Vector2 dir)
    {
        float sqrLenght = dir.sqrMagnitude;
        if (sqrLenght > 1)
        {
            dir = dir / Mathf.Sqrt(sqrLenght);
        }

        _dir = dir;
    }

    // Start is called before the first frame update
    void Start()
    {

        _rb = GetComponent<Rigidbody2D>();
        if  (originalSpeed <= 0) originalSpeed = speed;

    }



    void FixedUpdate()
    {
        if (_dir != Vector2.zero)
        {

            _rb.MovePosition( _rb.position + _dir * (speed * Time.fixedDeltaTime));

        }


    }

}