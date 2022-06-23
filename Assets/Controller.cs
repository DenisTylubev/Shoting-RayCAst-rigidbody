using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Quaternion origRoyayion;
    float angleHorizontal;
    float angVertical;
   public float mouseSpeed;

    private Transform tran;
    private void Start()
    {
        origRoyayion = transform.rotation;
        tran = GetComponent<Transform>();
    }
    private void FixedUpdate()
    {
        angleHorizontal += Input.GetAxis("Mouse X") * mouseSpeed;
       angVertical += Input.GetAxis("Mouse Y") * mouseSpeed;
        angVertical = Mathf.Clamp(angVertical, -60,60);
        Quaternion rotationX =Quaternion.AngleAxis(angleHorizontal, Vector3.up);
        Quaternion rotationY =Quaternion.AngleAxis(-angVertical, Vector3.right);
        transform.rotation = origRoyayion *rotationY * rotationX;

        var Hor = tran.right * Input.GetAxisRaw("Horizontal");
        var Ver = tran.forward * Input.GetAxisRaw("Vertical");
        tran.position += (Ver + Hor) * 3.0f * Time.deltaTime;
    }
}

   
   