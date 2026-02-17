using UnityEngine;
using TMPro; // Necesario para TextMeshPro

public class ControladorFuente : MonoBehaviour
{
    public TMP_Text textoDelCuento; // Aquí conectaremos el texto
    bool esGrande = false; // Para saber si ya le dimos clic

    public void CambiarTamano()
    {
        if (esGrande == false)
        {
            textoDelCuento.fontSize = 120; // Hacemos la letra grande
            esGrande = true;
        }
        else
        {
            textoDelCuento.fontSize = 80; // Regresamos al tamaño normal
            esGrande = false;
        }
    }
}