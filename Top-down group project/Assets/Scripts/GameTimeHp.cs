using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameTimeHp : MonoBehaviour
{
    public float levelTime = 120.0f;
    float timer = 0;
    public Text TimeText;
    public void Update()
    {
        TimeText.text = "Time: " + timer + "/100";
        timer += Time.deltaTime;
        if (timer > levelTime)
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            levelTime-=3;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            levelTime-=5;
        }
    }
}