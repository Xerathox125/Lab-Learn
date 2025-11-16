using UnityEngine;
using UnityEngine.Jobs;

public class CubeRotation : MonoBehaviour
{
    private Quaternion Quat;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Quat = Quaternion.Euler(1, 1, 1);
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = -transform.forward * 5f;
        */

    }

    // Update is called once per frame
    void Update()
    {
        //transform.rotation *= Quat;
        //transform.localScale += Vector3.one * 0.01f;
        
    }
}
