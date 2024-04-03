using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] GameObject ammo;
    [SerializeField]  Transform emission;
    [SerializeField] AudioSource audioSource;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.Play();
            Instantiate(ammo, emission.position, emission.rotation);
        }
    }
}
