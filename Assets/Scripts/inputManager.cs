using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    [SerializeField] PlayMove playMove;
    [SerializeField] CameraMove cameraMove;
    [SerializeField] Rigidbody rigidBody;
    private bool isGrounded = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        if (isGrounded) // Jump input
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playMove.Jump();
            }
        }

        Vector3 movementDirection = Vector3.zero; 

        if (Input.GetKey(KeyCode.A))
        {
            //playMove.Left();
            movementDirection.x = -1;
        }
        if (Input.GetKey(KeyCode.D)) 
        {
            //playMove.Right();
            movementDirection.x = 1;
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            //playMove.Forward();
            movementDirection.z = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            //playMove.Backward();
            
            movementDirection.z = -1;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //playMove.Sprint();
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //playMove.Crouch();
        }
        
        playMove.Movement(movementDirection);

        if(Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse X") < 0)
        {
            cameraMove.Look();
        }
        if (Input.GetAxis("Mouse Y") > 0 || Input.GetAxis("Mouse Y") < 0)
        {
            cameraMove.Look();
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //playMove.Attack();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            //playMove.Defend();
        }
        if (Input.GetKeyDown(KeyCode.E)) 
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
