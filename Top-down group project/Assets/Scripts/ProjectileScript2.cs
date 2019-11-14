using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript2 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = transform.position.z;
        transform.up = -mousePosition + transform.position;
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 moveDir = y * transform.up + x * transform.up;
        moveDir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
