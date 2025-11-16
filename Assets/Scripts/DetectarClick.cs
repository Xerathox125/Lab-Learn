using UnityEngine;

public class DetectarClick : MonoBehaviour
{
    public Coroutines Coroutine;

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        Physics.Raycast(ray, out hit);

        if (hit.collider.CompareTag("Suelo"))
        {
            Coroutine.Destino = hit.point + Vector3.up * 1.5f; 
        }

    }
}
