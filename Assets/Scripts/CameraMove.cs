using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private float xSensitivity;
    [SerializeField] private float ySensitivity;
    [SerializeField] private Rigidbody PlayerBody;
    private Vector3 initialOffset;
    private float xRotation;
    private float yRotation;
    private Transform PlayerCam;// = GetComponent<MainCamera>().transform;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        initialOffset = this.transform.position - targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = targetObject.position + initialOffset;

    }

    public void Look()
    {
        float mouseX = -Input.GetAxis("Mouse X") * Time.deltaTime * xSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * ySensitivity;
        
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        xRotation = xRotation - mouseY;
        yRotation = yRotation - mouseX;



        PlayerCam = this.transform;
        PlayerCam.localRotation = Quaternion.Euler(xRotation, yRotation, 0);
        PlayerBody.transform.Rotate(-Vector3.up * mouseX);


    }
}
