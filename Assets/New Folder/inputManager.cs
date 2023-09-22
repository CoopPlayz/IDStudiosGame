using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    private bool isGrounded = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        if (!isGrounded) // Jump input
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //PlayMove.Jump();
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //PlayMove.Left();
        }
        if(Input.GetKeyDown(KeyCode.D)) 
        {
            //PlayMove.Right();
        }
        if(Input.GetKeyDown(KeyCode.W))
        { 
            //PlayMove.Foward();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //PlayMove.Backward();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //PlayMove.Sprint();
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //PlayMove.Crouch();
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            //PlayMove.Attack();
        }
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            //PlayMove.Defeand();
        }
        if (Input.GetKeyDown(KeyCode.F)) 
        { 
            //PlayMove.Interact();
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 1)
        {
            //PlayMove.SwitchWeaponUP();
            //PlayMove.SwitchWeaponDown();
        }

    }
}
