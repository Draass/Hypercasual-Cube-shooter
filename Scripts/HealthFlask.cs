using UnityEngine;

public class HealthFlask : MonoBehaviour
{
    [SerializeField] private int healAmount = 50;
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
