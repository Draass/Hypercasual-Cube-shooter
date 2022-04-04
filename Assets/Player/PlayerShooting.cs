using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public Transform firePoint;
	public GameObject bulletPrefab;
	public float reloadTime = 0.5f;
	public float initialReloadTime = 0.5f;
	

	public float bulletForce = 20f;
	// Update is called once per frame
	void Update()
	{
		reloadTime -= Time.deltaTime;
		if (reloadTime <= 0)
        {
			Shoot();
			reloadTime = initialReloadTime;
        }

	}

	void Shoot()
	{
		GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
		Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
		rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
	}

	
   

    
}
