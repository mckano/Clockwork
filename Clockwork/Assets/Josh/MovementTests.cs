using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementTests : MonoBehaviour
{
    public SlowTimeManager slowTimeManager;
    int jumpCount = 0;
    public int totalJumps = 3;
    bool isGrounded = true;
    public Rigidbody rb;
    int layer;
    float rayLength;
    public GameObject player;
    public GameObject timeCamera;

    

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
        float zMove = Input.GetAxisRaw("Vertical") * Time.deltaTime ;

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
        if (Input.GetKey(KeyCode.E))
        {
            // float xMove = Input.GetAxisRaw("Horizontal") * Time.fixedDeltaTime * 1;
            // float zMove = Input.GetAxisRaw("Vertical") * Time.fixedDeltaTime * 1;
            //  rb.velocity = new Vector3(xMove * moveSpeed, rb.velocity.y, zMove * moveSpeed);
           
            slowTimeManager.SlowMotion();
           
            //timeCamera.SetActive(true);
           
        } 
        else
        {
           
            slowTimeManager.StopSlowMotion();
          
            //timeCamera.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            CameraVhsOn();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            CameraVhsOff();
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
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            jumpCount = totalJumps;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Platform"))
        {
            isGrounded = false;
        }

    }
    public void CameraVhsOn()
    {
        timeCamera.SetActive(true);
    }
    public void CameraVhsOff()
    {
        timeCamera.SetActive(false);
    }
}

