using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputManager : MonoBehaviour
{
    [SerializeField] PlayMove playMove;
    [SerializeField] CameraMove cameraMove;
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] PlayerDash playerDash;
    [SerializeField] Gun gun;

   
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
        if (PlayMove.isGrounded == true) // Jump input
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playMove.Jump();
            }
            //Vector3 movementDirection = Vector3.zero;

            if (Input.GetKey(KeyCode.A))
            {
                //playMove.Left();
                playMove.Movement();
                //movementDirection.x = -1;
            }
            if (Input.GetKey(KeyCode.D)) 
            {
                //playMove.Right();
                playMove.Movement();
                //movementDirection.x = 1;

            }
            if (Input.GetKey(KeyCode.W))
            {
                playMove.Movement();
            }
            if (Input.GetKey(KeyCode.S))
            {
                //playMove.Backward();
                playMove.Movement();
                //movementDirection.z = -1;
            }

            //bool isKeyPressed;
        
            if(!Input.anyKey && !playerDash.IsDashing )
            {
                Debug.Log("Zeroing Speed");
                rigidBody.velocity = new Vector3(0, rigidBody.velocity.y, 0);
                //rigidBody.velocity = Vector3.zero;
            }

            
        }

        playMove.directionalInput();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            playerDash.Dash();
        }
     

        /*
        if (Input.GetKey(KeyCode.LeftControl))
        {
            //playMove.Crouch();
        }
        
        */
        if (Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse X") < 0)
        {
            cameraMove.Look();
        }
        if (Input.GetAxis("Mouse Y") > 0 || Input.GetAxis("Mouse Y") < 0)
        {
            cameraMove.Look();
        }



        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            gun.Shoot();
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
            if (isPaused)
            {
                
            }
        }
    }
}
