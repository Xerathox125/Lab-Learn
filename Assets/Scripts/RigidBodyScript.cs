using UnityEngine;

public class RigidBodyScript : MonoBehaviour
{
    private Quaternion quat;
    private float rotacion;
    private Rigidbody rb;
    private Rigidbody cuboRb;
    public GameObject cubo;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        cuboRb = cubo.gameObject.GetComponent<Rigidbody>();        
        quat = Quaternion.Euler(1, 1, 0);

        rb.position = transform.position + Vector3.down * 4.5f;
        cubo.transform.position = cubo.transform.position + Vector3.down * 4.5f;


        //rb.mass = 1;
        //rb.linearVelocity = Vector3.right * 5;
        //cuboRb.linearVelocity = Vector3.left * 5;
        //rb.linearDamping = 5;
        //rb.angularDamping = 20;
        //rb.freezeRotation = true;
        //rb.isKinematic = true;
    }

    void Update()
    {
        //rb.Move(transform.position + Vector3.right * Time.deltaTime, rb.rotation * quat);
        rb.MovePosition(transform.position + Vector3.right * Time.deltaTime);
        rb.MoveRotation(rb.rotation * quat);
        /*
        rotacion = Input.GetAxis("Horizontal"); //para presionar a o d para moverlo, vertical es para w y s
        rb.AddRelativeForce(Vector3.right * 2);
        rb.AddTorque(Vector3.right * rotacion);
        */
    }
}
