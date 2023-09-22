using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    [SerializeField] PlayMove playMove;

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
                //playMove.Jump();
            }
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            //playMove.Left();
        }
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            //playMove.Right();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playMove.Forward();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //playMove.Backward();
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //playMove.Sprint();
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //playMove.Crouch();
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //playMove.Attack();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //playMove.Defeand();
        }
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            //playMove.Interact();
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 1)
        {
            //playMove.SwitchWeaponUP();

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 1)
        {

            //playMove.SwitchWeaponDown();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
            //GameMenu.PauseMenu
        }
    }
}
