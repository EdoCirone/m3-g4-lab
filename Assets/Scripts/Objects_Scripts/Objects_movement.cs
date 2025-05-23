using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects_movement : MonoBehaviour
{ 
    enum TIPEOFMOVIMENT
    {
        Scale,
        Vertical,
        Horizontal,
    }

    Vector2 Startpos;
    Vector2 Startscale;

    [SerializeField] float frequency = 1.0f;
    [SerializeField] float amplitude = 1.0f;
    [SerializeField] TIPEOFMOVIMENT movimenType;


    // Start is called before the first frame update
    void Start()
    {

        Startpos = transform.position;
        Startscale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

        if (movimenType == TIPEOFMOVIMENT.Vertical)
        {

            float positionOffset = Mathf.Sin(frequency * Time.time) * amplitude;
            transform.position = Startpos + new Vector2( 0 , positionOffset);

        }
        else if (movimenType == TIPEOFMOVIMENT.Horizontal)
        {
            float positionOffset = Mathf.Sin(frequency * Time.time) * amplitude;
            transform.position = Startpos + new Vector2(positionOffset, 0);
        }
        else if (movimenType == TIPEOFMOVIMENT.Scale)
        {

            float positionOffset = Mathf.Sin(frequency * Time.time) * amplitude;
            transform.localScale = Startscale + new Vector2(positionOffset, positionOffset);

        }

    }
}