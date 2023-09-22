using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    private Vector3 initialOffset;

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
}
