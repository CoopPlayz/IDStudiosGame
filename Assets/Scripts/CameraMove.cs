using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private float sensitivity;
    [SerializeField] private Rigidbody PlayerBody;
    private Vector3 initialOffset;
    private float xRotation;
    private Transform PlayerCam;// = GetComponent<MainCamera>().transform;

    // Start is called before the first frame update
    void Start()
    {
        initialOffset = this.transform.position - targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = targetObject.position + initialOffset;

    }

    public void Look()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivity;

        xRotation = xRotation - mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        PlayerCam = this.transform;
        PlayerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);
        PlayerBody.MoveRotation(PlayerCam.localRotation);


    }
}
