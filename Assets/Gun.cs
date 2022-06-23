using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage;
    public float range;
    public Camera cam;
    public Rigidbody rb;
    public Transform spavnPosithion;
    public float throwForce;


   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {

            Shoot();

        }
        if(Input.GetKeyDown(KeyCode.Mouse2))
        {

            ShootBall();
           
        }
        
    }

    void ShootBall()
    {
        Rigidbody spavn;
         spavn =  Instantiate(rb, spavnPosithion.position,spavnPosithion.rotation) as Rigidbody;
        spavn.AddForce(spavnPosithion.forward * throwForce * 10);


    }
     void Shoot()
    {
        RaycastHit hit;
         if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit,range))
        {
            Tsrget  target =  hit.transform.GetComponent<Tsrget>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }


        }

    }
}
