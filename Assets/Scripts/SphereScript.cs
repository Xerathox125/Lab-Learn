using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public GameObject esfera;
    private Rigidbody rb;
    public GameObject cilindo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //transform.position += Vector3.one * 4.0f;
        rb = GetComponent<Rigidbody>();

        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            transform.localScale += Vector3.one;
            cilindo.transform.position += Vector3.right;
        }
        //Instantiate(esfera);
    }
}
