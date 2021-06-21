using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTests : MonoBehaviour
{
    int jumpCount = 0;
    public int totalJumps = 3;
    bool isGrounded = true;
    public Rigidbody rb;
    int layer;
    float rayLength;

    public float moveSpeed;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        jumpCount = totalJumps;
        rb = GetComponent<Rigidbody>();
        layer = LayerMask.GetMask("Floor");
        rayLength = transform.localScale.y / 2;
    }

    void FixedUpdate()
    {
        float xMove = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float zMove = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        rb.velocity = new Vector3(xMove * moveSpeed, rb.velocity.y, zMove * moveSpeed);
    }
       
    void Update()
     {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (jumpCount > 0)
            {
                Jump();
            }
        }
            
    }
        
    void Jump()
    {
       rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse) ;
        // rb.velocity = new Vector3(rb.velocity.x, 0f);
       jumpCount -= 1;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = totalJumps;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

    }
}

