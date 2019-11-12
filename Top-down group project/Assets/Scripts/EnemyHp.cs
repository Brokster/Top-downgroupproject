using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int health = 3;
    public float knockbackForce = 5.0f;
    public GameObject prefab;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            health--;
            GetComponent<EnemyAI>().knockBack = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(transform.position.x - collision.gameObject.transform.position.x, 
                transform.position.y - collision.gameObject.transform.position.y) * knockbackForce;
            if (health < 1)
            {
                GameObject Clock = Instantiate(prefab, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
