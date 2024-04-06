using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class Ammo : MonoBehaviour
{
    [SerializeField] public float speed = 1;
    [SerializeField] public float lifespan = 0;
   public Rigidbody rb;
    void Start()
    {
        if(lifespan > 0)Destroy(gameObject, lifespan);
        rb = GetComponent<Rigidbody>();

       // rb.AddRelativeForce(transform.rotation * Vector3.forward, ForceMode.VelocityChange);
        rb.AddRelativeForce(transform.forward * speed, ForceMode.VelocityChange);

        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
