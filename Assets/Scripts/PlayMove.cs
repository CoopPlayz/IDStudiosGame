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
        
    }
    public void Forward()
    {
        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, straightLineSpeed * Time.deltaTime);
    }
    public void Jump()
    {
        
    }
}
