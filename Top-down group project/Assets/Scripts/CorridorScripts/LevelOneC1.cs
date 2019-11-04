using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneC1 : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("CorridorOne");
    }
    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("CorridorOne");
        if(enemies.Length == 0)
        {
            Destroy(gameObject);
        }
    }
}
