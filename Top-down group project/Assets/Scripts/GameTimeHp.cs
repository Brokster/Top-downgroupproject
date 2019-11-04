using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameTimeHp : MonoBehaviour
{
    public float timer = 0;
    public Text TimeText;
    private void Start()
    {
        timer = 120.0f;
    }
    public void Update()
    {
        TimeText.text = "Time: " + timer + "/100";
        TimeText.text = "Time left: " + Mathf.RoundToInt(timer);
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "CorridorOne" 
            || collision.gameObject.tag == "CorridorTwo" || collision.gameObject.tag == "CorridorThree")
        {
            timer-=3;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "CorridorOne" 
            || collision.gameObject.tag == "CorridorTwo" || collision.gameObject.tag == "CorridorThree")
        {
            timer-=5;
        }
    }
}