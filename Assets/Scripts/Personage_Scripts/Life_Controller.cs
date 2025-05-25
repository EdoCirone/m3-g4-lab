using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Controller : MonoBehaviour
{

    int health = 100;
    [SerializeField] int maxHealth = 100;
    public int CurrentHealth => health;
    public int MaxHealth => maxHealth;

    bool isDead = false;

    private void Awake()
    {
        health = maxHealth;
    }

    public bool CheckDeath()
    {
        if (health <= 0 && !isDead)
        {
            isDead = true;
            Destroy(gameObject);
            Debug.Log("il giocatore � stato  sconfitto");
            return true;

        }
        else
        {
            return false;
        }


    }

    public void TakeDamage(int amount)
    {

        if (!isDead && amount >= 0)
        {

            health -= amount;
            Debug.Log($"Ho subito {amount} danni, ora la mia vita � {health}");
            CheckDeath();
        }
        else{
            Debug.Log("Sei già morto");
        }

    }



    public void TakeHeal(int amount)
    {


        if (!isDead && amount > 0 && health < maxHealth)
        {
            int previousHealth = health;
            health = Mathf.Min(health + amount, maxHealth);
            int effectiveAmount = health - previousHealth;
            Debug.Log($"Mi sono curato di {effectiveAmount} ora la mia vita � {health}");
        }
        else
        {
            Debug.Log("La tua vita � gi� al massimo");
        }


    }

    public float GetHealthPercent()
    {
        return Mathf.Clamp01((float)health / maxHealth);
    }

}
