using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneC2 : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("CorridorTwo");
    }
    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("CorridorTwo");
        if (enemies.Length == 0)
        {
            Destroy(gameObject);
        }
    }
}
