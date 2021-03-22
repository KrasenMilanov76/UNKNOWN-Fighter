using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHurtSystem : MonoBehaviour
{
    public Animator animator;
    public GameManager gameManager;
    public int maxHealth = 100;
    public int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        animator.SetTrigger("Hurt");
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        animator.SetBool("IsDead", true);
        gameManager.LevelLost();
        GetComponent<MovementScript>().enabled = false;
        GetComponent<PlayerCombat>().enabled = false;
      
        
    }
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            TakeDamage(100);
        }
    }
}
