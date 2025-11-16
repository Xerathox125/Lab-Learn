using NUnit.Framework.Constraints;
using UnityEngine;
using UnityEngine.Rendering;

public class Sphere2Script : MonoBehaviour
{
    private GameObject EsferaAzul;
    private Vector2 Vector2 = new Vector2(1, 1);
    private Vector3 Vector3_2 = new Vector3(0.5f, 0.5f, 0);
    private Vector3 Vector3 = new Vector3(0, 0, 0.5f);
    private bool creciendo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        CapsuleScript.numero +=1;
        EsferaAzul = GameObject.FindWithTag("other");
    }

    // Update is called once per frame
    void Update()
    {

        if (creciendo == true)
        {
            transform.localScale += Vector3.one * 0.01f;
        }

        transform.position += Vector3.down * 0.005f;

        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.position += Vector3_2;
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position += Vector3;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EsferaAzul")
        {
            creciendo = true;
        }


        if (other.gameObject.tag == "EsferaVerde")        
        {
            transform.position += Vector3.up * 5;
            //other.gameObject.SetActive(true);
        }



    }

    private void OnTriggerStay(Collider other)
    {
        /*if (other.gameObject.tag == "EsferaAzul")
        {
            transform.localScale += Vector3.one * 0.01f;
        }
        */
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EsferaAzul")
        {
            transform.localScale = Vector3.one;
            creciendo = false;
        }
    }
}
