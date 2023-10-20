using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayMove : MonoBehaviour
{
    private float moveSpeed = 15;
    private float maxSpeed = 15;

    [SerializeField] private float jumpForce = 500;
    [SerializeField] private Transform orientationCam;

    private Rigidbody rigidBody;
    private Rigidbody rigidBodyExtra;
    private float x, y;

    public static bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
        //caching
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mouseInput()
    {
        y = Input.GetAxisRaw("Vertical");
        x = Input.GetAxisRaw("Horizontal");
    }

    public void Movement()
    {
        /*
        if (x > 0 && xMag > maxSpeed) x = 0;
        if (x < 0 && xMag < -maxSpeed) x = 0;
        if (y > 0 && yMag > maxSpeed) y = 0;
        if (y < 0 && yMag < -maxSpeed) y = 0;
        */

        float yVelocity = rigidBody.velocity.y;
        rigidBody.AddForce(orientationCam.transform.forward * y * moveSpeed * 0.5f);
        rigidBody.AddForce(orientationCam.transform.right * x * moveSpeed *0.25f);
        rigidBody.velocity = new Vector3(Mathf.Clamp(rigidBody.velocity.x, -maxSpeed, maxSpeed), yVelocity, Mathf.Clamp(rigidBody.velocity.z, -maxSpeed, maxSpeed));
    }

    

    /*
    public void Left()
    {

        rigidBody.velocity = new Vector3(-moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
    }

    public void Movement(Vector3 direction)
    {
        Vector3 movement = orientationCam

        movement.x *= direction.x * moveSpeed;
        movement.y = rigidBody.velocity.y;
        movement.z *= direction.z * moveSpeed;

        rigidBody.velocity = movement;

        //rigidBody.velocity = transform.forward * moveSpeed;


    }

    public void Right()
    {
        rigidBody.velocity = new Vector3(moveSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
    }
    public void Forward()
    {
        rigidBodyExtra.velocity = transform.forward * moveSpeed;
        rigidBody.velocity = new Vector3(rigidBody.velocity.x + rigidBodyExtra.velocity.x, rigidBody.velocity.y, rigidBodyExtra.velocity.z);
        
    }
    public void Backward()
    {
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, -moveSpeed);
    }
    */
    public void Jump()
    {
        //rigidBody.velocity = new Vector3(rigidBody.velocity.x, jumpForce, rigidBody.velocity.z);
        rigidBody.AddForce(orientationCam.transform.up * jumpForce);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contacts[0].normal.y > 0.5)
        {
            Debug.Log("Youre grounded");
            isGrounded = true;
        }
        
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Youre grounded");
            isGrounded = true;
        }
    }
    */
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Youre not grounded");
            isGrounded = false;
        }
    }
}
