using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDash : MonoBehaviour
{
    
    public float speed = 1f;
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            //transform.position += new Vector3(speed * Time.deltaTime, 0.1f, 0.0f);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
            
    }
}

