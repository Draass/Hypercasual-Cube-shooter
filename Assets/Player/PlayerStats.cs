using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverUI;

    public bool isDead;

    public float hp;
    public float initialHP = 100f;

    public HealthBar healthBar;

    void Start()
    {
        isDead = false;
        hp = initialHP;
        healthBar.SetMaxHealth(initialHP);
    }

    // Update is called once per frame
    void Update()
    {
        //check if player has more hp than he is allowed
        if (hp > initialHP)
        {
            hp = initialHP;
        }

        Die();
    }

    void Die()
    {
        if (hp <= 0)
        {
            isDead = true;
            Debug.Log("You are dead!");
            Destroy(player);
            gameOverUI.SetActive(true);
        }

    }

    public void Heal(int healAmount)
    {
        hp += healAmount;
        healthBar.SetHealth(hp);
    }

    public void TakeDamage(int damage)
    {

        hp -= damage;
        healthBar.SetHealth(hp);
    }
}
