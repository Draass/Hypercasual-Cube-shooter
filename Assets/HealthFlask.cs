using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFlask : MonoBehaviour
{

    public int healAmount = 50;
    public GameObject healEffect;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
        if (player != null)
        {
            player.Heal(healAmount);
            Instantiate(healEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
