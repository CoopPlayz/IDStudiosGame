using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform targetObject;
    [SerializeField] private Rigidbody PlayerBody;

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
