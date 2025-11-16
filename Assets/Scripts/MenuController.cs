using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public void CambiarEscena(string escena)
    {
        SceneManager.LoadScene(escena);
    }

    public void MostrarTexto()
    {
        texto.text = "Bienvenido!";
    }

}
