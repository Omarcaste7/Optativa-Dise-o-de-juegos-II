using UnityEngine;

public class ControladorEnlaces : MonoBehaviour
{
    // Función pública para que el botón la vea
    public void AbrirPaginaWeb(string url)
    {
        Application.OpenURL(url);
        Debug.Log("Abriendo página: " + url);
    }
}