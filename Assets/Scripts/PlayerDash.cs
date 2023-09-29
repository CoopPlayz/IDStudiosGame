using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerDash : MonoBehaviour
{
    public float speed = 1f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0.1f, 0.0f);
        }
            
    }
}

