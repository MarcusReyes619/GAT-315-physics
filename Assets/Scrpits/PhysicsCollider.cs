using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsCollider : MonoBehaviour
{
    [SerializeField] GameObject fx;
    string status;
    Vector3 contact;
    Vector3 normal;

    private void OnCollisionEnter(Collision collision)
    {
        status = "Collision enter " + collision.gameObject.name;

        contact = collision.contacts[0].point;
        normal = collision.GetContact(0).normal;

        Instantiate(fx, contact, Quaternion.LookRotation(normal));
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        status = "Trigger enter " + other.gameObject.name;

    }
    private void OnTriggerStay(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        
    }

    private void OnGUI()
    {
        GUI.skin.label.fontSize = 16;
        Vector2 screen = Camera.main.WorldToScreenPoint(transform.position);
        GUI.Label(new Rect(screen.x,Screen.height-screen.y,250,70),status);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(contact, 0.2f);
        Gizmos.DrawLine(contact, contact + normal);
    }
}
