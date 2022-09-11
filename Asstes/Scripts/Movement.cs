
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 10f, vertical, horizontal;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        vertical = Input.GetAxis("Vertical") * speed;
        horizontal = Input.GetAxis("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        rb.MovePosition(
           transform.position +
           transform.right * horizontal * Time.fixedDeltaTime +
           transform.forward * vertical * Time.fixedDeltaTime
        );
    }
}