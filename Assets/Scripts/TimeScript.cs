using UnityEngine;

public class TimeScript : MonoBehaviour
{
    public GameObject Cubo;
    public float tiempo;

    void Start()
    {
        tiempo = 1;
    }

    void Update()
    {
        transform.Translate(new Vector3(0.5f,0,0)*Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            tiempo = 0.2f;
            Time.timeScale = tiempo;            
        }
    }

    void FixedUpdate()
    {
        Cubo.transform.Translate(new Vector3(0.5f, 0, 0)*Time.fixedDeltaTime);
    }
}
