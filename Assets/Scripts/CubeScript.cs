using UnityEngine;

public class CubeScriptp : MonoBehaviour
{
    private CapsuleScript CapsuleScript;
    private BoxCollider BoxCollider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BoxCollider = GetComponent<BoxCollider>();
        CapsuleScript.numero = 10;
        CapsuleScript.CapsulaFixed.transform.position = Vector3.one;
        

    }

    // Update is called once per frame
    void Update()
    {
        BoxCollider.size += Vector3.one * 0.01f;
    }



}
