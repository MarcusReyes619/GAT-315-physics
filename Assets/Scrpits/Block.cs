using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Block : MonoBehaviour
{

    [SerializeField] int points = 100;
    [SerializeField] AudioSource audioSource;

    Rigidbody rb;
    bool destoryed = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(rb.velocity.magnitude > 2 || rb.angularVelocity.magnitude > 2)
        {
            audioSource.Play();
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if (!destoryed && other.CompareTag("Kill") && 
            rb.velocity.magnitude == 0 
            && rb.angularVelocity.magnitude ==0)
        { 
            destoryed = true;
            print(points);
            Destroy(gameObject, 2);
        }
    }
}
