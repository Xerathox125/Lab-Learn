using System.Security.Cryptography;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private Collider Coll;
    private Ray rayo;
    private RaycastHit hit;
    private Vector3 posInicial;
    private Rigidbody rb;
    void Start()
    {
        Coll = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        posInicial = transform.position;
        /*
        rayo = new Ray(transform.position + Vector3.left * 2, Vector3.right);
        if (Coll.Raycast(rayo, out hit, 2))
        {
            hit.rigidbody.useGravity = true;
        }

        Debug.DrawRay(rayo.origin, rayo.direction * 2, Color.red, 10);
        */
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Velocidad: " + collision.relativeVelocity.magnitude);
        if(collision.relativeVelocity.magnitude > 5)
        {
            transform.position = posInicial;
        }
    }


    private void OnCollisionStay(Collision collision)
    {
        rb.AddForce(Vector3.left * 13);
    }

    private void OnCollisionExit(Collision collision)
    {
        transform.position = posInicial;
    }
}
