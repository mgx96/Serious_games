using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMoving : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Vertical"))
        {
            transform.Translate(Input.GetAxis("Vertical")*speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetButton("Horizontal"))
        {
            transform.Translate(0, 0, -1*Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        }
    }
}
