using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    private CapsuleCollider CapsuleCollider;
    public GameObject Cubo;
    private Transform ChildTransform;
    public GameObject CapsulaFixed;
    private GameObject Objeto;
    public static int numero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        //transform.position = Vector3.one;
    }

    void Start()
    {
        //transform.position = Vector3.one;
        ChildTransform = transform.GetChild(0);
        CapsuleCollider = GetComponentInChildren<CapsuleCollider>();
        CapsuleCollider.isTrigger = true;
        Destroy(Cubo);
    }


    // Update is called once per frame
    void Update()
    {
        if (Cubo != null)
        {
            Cubo.transform.LookAt(ChildTransform.position);
            Cubo.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        ChildTransform.Rotate(1, 0, 0);

        //transform.position += Vector3.right * 0.05f;
        ChildTransform.position += Vector3.down * 0.01f;

    }

    private void FixedUpdate()
    {
        //CapsulaFixed.transform.position += Vector3.right * 0.05f;
    }
}
