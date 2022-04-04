using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletParameters : MonoBehaviour
{
    public GameObject bullet;

    public float timeToDestroy;
    public int bulletDamage;
    public GameObject impactEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(bullet);
        
        PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
        if (player != null)
        {
            player.TakeDamage(bulletDamage);
        }
        
    }



    private void Update()
    {
        Destroy(bullet, timeToDestroy);

        //Instantiate impact effect
        //Instantiate(impactEffect, transform.position, transform.rotation);
    }
}
