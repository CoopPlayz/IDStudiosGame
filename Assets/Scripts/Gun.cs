using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private int ammo;

    // Start is called before the first frame update
    void Start()
    {
        ammo = 5;
    }

    // Update is called once per frame
    void Update()
    {
        gun.transform.Rotate(Vector3.up);
        if (ammo == 0)
        {
            reload();
        }
        else
        {/*
            if(Shoot() == true)
            {
                ammo -= 1;
            }
            */
        }
        
    }
    public void Shoot()
    {
        Debug.Log("Youve take a shot");
    }
    private void reload()
    {
        this.transform.Rotate(Vector3.up);
    }
}
