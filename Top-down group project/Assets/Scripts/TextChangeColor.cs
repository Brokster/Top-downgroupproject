using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextChangeColor : MonoBehaviour
{
    public class CollisionColorChange : MonoBehaviour
    {

        public Color redcolor;
        public Color bluecolor;


        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                transform.GetComponent<Renderer>().material.color = bluecolor;
            }
        }
    }   
}
