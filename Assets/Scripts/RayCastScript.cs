using UnityEngine;

public class RayCastScript : MonoBehaviour
{
    private Ray rayo;
    private RaycastHit hit;
    private Rigidbody rb;
    public float torque;
    private float rotacion;
    
    void Start()
    {
        torque = 1;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rayo = new Ray(transform.position, transform.forward);
        rotacion = Input.GetAxis("Horizontal");
        rb.AddTorque(Vector3.up * torque * rotacion);

        if (Physics.Raycast(rayo, out hit, 9))
        {
            Colision(hit);
        }
        Debug.DrawRay(transform.position, transform.forward * 9, Color.red);
    }


    private void Colision(RaycastHit hit)
    {
        if(hit.collider.CompareTag("Enemigo"))
        {
            hit.rigidbody.useGravity = true;
            hit.rigidbody.AddForce(rayo.direction * 20);
        }
        else if (hit.collider.CompareTag("CaraFeliz"))
        {
            hit.transform.Rotate(new Vector3(5, 5, 5));
        }
        else if (hit.collider.CompareTag("CuboAmarillo"))
        {
            hit.transform.localScale += Vector3.one * 0.005f;
        }
    }
}
