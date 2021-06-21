using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    Rigidbody rb;
    int layer;
    float rayLength;

    public float moveSpeed;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        layer = LayerMask.GetMask("Floor");
        rayLength = transform.localScale.y / 2;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float zMove = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        rb.velocity = new Vector3(xMove * moveSpeed, rb.velocity.y, zMove * moveSpeed);
    }

    private void Update()
    {
        //if (rb.velocity.y < 0)
        //    rb.velocity +=


        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), rayLength, layer))
            {
                rb.AddForce(rb.velocity.x, jumpForce, rb.velocity.z);
            }
        }
    }
}
