using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Controller : MonoBehaviour
{

    int health = 100;
    [SerializeField] int maxHealth = 100;
    public int CurrentHealth => health;
    public int MaxHealth => maxHealth;

    private void Awake()
    {
        health = maxHealth;
    }

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

    public void TakeDamage(int amount)
    {

        health -= amount;
        Debug.Log($"Ho subito {amount} danni, ora la mia vita è {health}");
        CheckDeath();

    }



    public void TakeHeal(int amount)
    {


        if (health != maxHealth)
        {
            int previousHealth = health;
            health = Mathf.Min(health + amount, maxHealth);
            int effectiveamount = health - previousHealth;
            Debug.Log($"Mi sono curato di {effectiveamount} ora la mia vita è {health}");
        }
        else
        {
            Debug.Log("La tua vita è già al massimo");
        }


    }

    public float GetHealthPercent()
    {
        return Mathf.Clamp01((float)health / maxHealth);
    }

}
