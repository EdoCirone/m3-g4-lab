using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Controller : MonoBehaviour
{

    int health = 100;
    [SerializeField] int maxHealth = 100;

   private bool CheckDeath()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("il giocatore è stato  sconfitto");
            return true;

        }
        else
        {
            return false;
        }
        

    }

    public void TakeDamage(int ammount)
    {

        health -= ammount;
        Debug.Log($"Ho subito {ammount} danni, ora la mia vita è {health}");
        CheckDeath();

    }

 

    public void TakeHealt(int ammount)
    {

        health += ammount;
        health = Mathf.Min(maxHealth, health);
        Debug.Log($"Mi sono curato di {ammount} ora la mia vita è {health}");

    }

    public float GetHealthPercent()
    {
        return Mathf.Clamp01((float)health / maxHealth);
    }

    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}
