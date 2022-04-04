using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp = 20;
    public GameObject deathEffect;
    public int enemyDamage = 20;

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp <= 0)
        {
            Die();
        }
    }

    public void DealDamage()
    {

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
        if (player != null)
        {
            player.TakeDamage(enemyDamage);
        }
    }

    public void Die()
    {
        Debug.Log("Enemy is dead");
        Destroy(gameObject);
        //Instantiate death effect
        Instantiate(deathEffect, transform.position, transform.rotation);
        Destroy(deathEffect, 5f);
    }
}
