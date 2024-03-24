using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unfreeze : MonoBehaviour
{

    private Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colision");
        if (rb.constraints != RigidbodyConstraints.None)
        {
            Debug.Log("setting shit to none");
            rb.constraints = RigidbodyConstraints.None;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
