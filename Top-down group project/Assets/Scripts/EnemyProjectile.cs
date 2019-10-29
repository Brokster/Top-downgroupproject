using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Vector2 paceDirection;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Vector2 ProjectileDirection = new Vector2(player.position.x - transform.position.x,
                player.position.y - transform.position.y);
        ProjectileDirection.Normalize();
        transform.right = ProjectileDirection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
