using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigBodyMover : MonoBehaviour
{
    [SerializeField] Vector3 force;
    [SerializeField] ForceMode mode;
    [SerializeField] Vector3 torque;
    [SerializeField] ForceMode torquemode;
    [SerializeField] KeyCode jumpKey;



    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(jumpKey))
        {
            rb.AddForce(Vector3.up, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddRelativeForce(force, mode);
            rb.AddTorque(torque, torquemode);
        }
    }
}
