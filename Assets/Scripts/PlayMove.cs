using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMove : MonoBehaviour
{
    [SerializeField] private float straightLineSpeed;
    [SerializeField] private float horizontalSpeed;
    [SerializeField] private float jumpForce;

    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        //caching
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        int zeroSpeed = 0;
    }
    public void Left()
    {

        rigidBody.velocity = new Vector3(-horizontalSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
    }

    public void Movement(Vector3 direction)
    {
        Vector3 movement;

        movement.x = direction.x * horizontalSpeed;
        movement.y = rigidBody.velocity.y;
        movement.z = direction.z * horizontalSpeed;

        rigidBody.velocity = movement;



    }

    public void Right()
    {
        rigidBody.velocity = new Vector3(horizontalSpeed, rigidBody.velocity.y, rigidBody.velocity.z);
    }
    public void Forward()
    {
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, straightLineSpeed);
    }
    public void Backward()
    {
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, -straightLineSpeed);
    }
    public void Jump()
    {
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, jumpForce, rigidBody.velocity.z);
    }
}
