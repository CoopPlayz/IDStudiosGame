using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private int ammo;
    private bool isReloading = false;
    private float timeToRotate = 1.01f;
    private float rotateTimer;
    private Vector3 gunRot;
    //[SerializeField] AnimationCurve rotationSpeedCurve;

    // Start is called before the first frame update
    void Start()
    {
        ammo = 5;
        rotateTimer = 0;
        gunRot = new Vector3 (0,this.transform.localEulerAngles.y,0);
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
        if (isReloading == false)
        {
            Debug.Log("Youve taken a shot");
            ammo -= 1;
        }
        

    }
    private void reload()
    {
        isReloading = true;
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
            this.transform.localEulerAngles = gunRot;
            isReloading = false;
        }
        
    }
}
