using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilePhysics : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        Vector3 reflectedVelocity = Vector3.Reflect(rb.velocity, other.contacts[0].normal);
        rb.velocity = Vector3.zero;
        rb.AddForce(reflectedVelocity, ForceMode.VelocityChange);
    }
}
