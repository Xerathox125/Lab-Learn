using System.Collections;
using UnityEngine;


public class Coroutines : MonoBehaviour
{

    private Vector3 inicio;
    private Vector3 destino;
    private Coroutine Corutina;

    public Vector3 Destino
    {
        get { return destino; }
        set {
            destino = value;
            if (Corutina != null)
            {
                StopCoroutine(Corutina); // Detenemos la corrutina que se esté ejecutando
            }
            //StopAllCoroutines();
            IniciarCorutina(destino); //Iniciamos la corutina con el nuevo destino
         
        }
    }

    void Start()
    {
        inicio = transform.position;
    }

    private void IniciarCorutina(Vector3 destino) { 
        Corutina = StartCoroutine(Mover_Volver(destino)); //Tenemos una referencia a la corutina
    }

    IEnumerator Mover_Volver(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, destino, 8 * Time.deltaTime); //mueve el objeto un poco
            yield return null; //salta al sig frame
        }
    
        yield return new WaitForSeconds(1); //espera 1 segundo


        while (Vector3.Distance(transform.position, inicio) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, inicio, 8 * Time.deltaTime); //mueve el objeto un poco
            yield return null; //salta al sig frame
        }
    }

}
