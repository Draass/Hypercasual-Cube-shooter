using UnityEngine;

public class BulletParameters : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    [Header("Bullet parameters")]
    [SerializeField] private float timeToDestroy;
    [SerializeField] private int bulletDamage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(bullet);
        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(bulletDamage);
        }
    }

    private void Update()
    {
        Destroy(bullet, timeToDestroy);
    }
}
