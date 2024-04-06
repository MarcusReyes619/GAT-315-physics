using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class AmmoBoom : MonoBehaviour
{
    [SerializeField] private float triggerForce = 0.5f;
    [SerializeField] private float explosionRadius = 5;
    [SerializeField] private float explosionForce = 500;
    [SerializeField] private GameObject fx;
    [SerializeField] AudioSource audioSource;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude >= triggerForce)
        {
            //OverlapSphere returns and array of objs that are hit by the colidder
            var surrondingObj = Physics.OverlapSphere(transform.position, explosionRadius);

            foreach (var obj in surrondingObj)
            {
                Rigidbody rb = obj.GetComponent<Rigidbody>();
                if (rb == null) continue;
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            }
            Instantiate(fx, transform.position, Quaternion.identity);
            audioSource.Play();

            Destroy(gameObject);

        }

    }

}
