using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LiveBar : MonoBehaviour
{
    [SerializeField] Life_Controller lifeController; // Assegna via Inspector o via script
    [SerializeField] float fullWidth = 1f;

    void Update()
    {
        if (lifeController != null)
        {
            float percent = lifeController.GetHealthPercent();
            Vector3 scale = transform.localScale;
            scale.x = fullWidth * percent;
            transform.localScale = scale;
        }
    }
}