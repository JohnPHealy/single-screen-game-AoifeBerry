using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;
    public HealthBar healthBar;
    public int chest;
  

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        chest = 0;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakenDamage(1);
       



        }

        if (other.gameObject.tag == "health")
        {
            heal(1);
            Destroy(other.gameObject);

        }

        if (other.gameObject.tag == "Chest")
        {
            chest += 1;
        }

        if (chest >= 6)

        {

            SceneManager.LoadScene("YouWin");
        }


    }

    void heal(int damage)
    {
        currentHealth += damage;
        healthBar.SetHealth(currentHealth);

    }


    void TakenDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
           // Debug.Log("Dead");
            SceneManager.LoadScene("Mainlevel");
        }

       
    }

  
}
