using UnityEngine;

public class ControladorNavegacion : MonoBehaviour
{
    // Aquí arrastraremos tus dos grandes paneles
    public GameObject portada;   // Tu VentanaPrincipal
    public GameObject contenido; // Tu Panel_Contenido nuevo

    // Función para el botón "Iniciar"
    public void IrAlContenido()
    {
        portada.SetActive(false);
        contenido.SetActive(true);
    }

    // Función para el botón "Regresar"
    public void IrALaPortada()
    {
        portada.SetActive(true);
        contenido.SetActive(false);
    }
    // Función para cerrar la aplicación
    public void SalirDelJuego()
    {
        Debug.Log("Cerrando aplicación..."); // Mensaje para probar en el editor
        Application.Quit(); // Esto cierra la app real
    }
}