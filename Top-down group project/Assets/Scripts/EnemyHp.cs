using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int health = 3;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x - collision.gameObject.transform.position.x, 
                transform.position.y - collision.gameObject.transform.position.y));
            if (health < 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
