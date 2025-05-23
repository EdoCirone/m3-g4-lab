using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]float speed = 5;
    float h;
    float v;

    public float GetSpeed()
    {
        return speed;
    }

   public void SetSpeed(float speed)
    { this.speed = speed; }

    // Start is called before the first frame update
    void Start()
    {

        _rb = GetComponent<Rigidbody2D>();
        
    }

    private void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 movement = new Vector2(h, v);

        if (movement.sqrMagnitude > 1)
        {
            movement = movement.normalized;
        }

        _rb.velocity =  movement * speed;

    }
}
