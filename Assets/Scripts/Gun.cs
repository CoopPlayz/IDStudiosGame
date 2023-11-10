using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private int ammo;
    private float timeToRotate = 5.0f;
    private float rotateTimer;

    // Start is called before the first frame update
    void Start()
    {
        ammo = 5;
        rotateTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ammo == 0)
        {   
            reload();
        }
        else
        {
        }
        
    }
    public void Shoot()
    {
        Debug.Log("Youve taken a shot");
        ammo -= 1;
    }
    private void reload()
    {
        rotateTimer += Time.deltaTime;
        if (rotateTimer < timeToRotate)
        {
            this.transform.Rotate(Vector3.forward);
            Debug.Log("Youre reloading");
        }
        else
        {
            ammo = 5;
            rotateTimer = 0f;
        }
        
    }
}
