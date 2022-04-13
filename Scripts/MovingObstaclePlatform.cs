using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstaclePlatform : MonoBehaviour
{
    public Transform pos1, pos2;

    [SerializeField] private float speed = 2f;
    public Transform startPos;

    [SerializeField] private int obstacleDamage = 20;
    [SerializeField] private float rotateSpeed = 0f;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        PlayerStats player = collision.gameObject.GetComponent<PlayerStats>();
        if (player != null)
        {
            player.TakeDamage(obstacleDamage);
        }
    }

    // Update is called once per frame
    void Update()
    {
        FindNextPosition();
        MoveToPosition();

        //prevent bug when platforms move even if Time.deltaTime = 0
        if (Time.deltaTime > 0)
        {
            transform.Rotate(0, 0, rotateSpeed);
        }
        
    }

    void FindNextPosition ()
    {
        if (transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
    }
    void MoveToPosition ()
    {
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }
}
