using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpanwerRagDoll : MonoBehaviour
{
    [SerializeField] GameObject ragDoll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(ragDoll);
        }   
    }
}
