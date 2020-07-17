using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;

    private Rigidbody2D rb;

    public GameObject Introduction;

    void Start()
    {
        Instantiate(Introduction, transform.position, transform.rotation);
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f);
        if (Exit.InputEnabled == true)
        {
            rb.AddForce(movement * speed);
        }
    }
}

