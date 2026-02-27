using UnityEngine;

public class DetectorComida : MonoBehaviour
{
    // Conectamos con el cerebro del juego de la actividad 3
    public LogicaJuego gameManager; 

    // Esta función de Unity equivale a la del minuto 4:20 del video
    void OnTriggerEnter2D(Collider2D otroObjeto)
    {
        // Revisamos qué etiqueta tiene lo que entró a la boca
        if (otroObjeto.CompareTag("Buena"))
        {
            gameManager.ComerBananaBuena();
            Destroy(otroObjeto.gameObject); // Cambio de estado: La comida desaparece
        }
        else if (otroObjeto.CompareTag("Mala"))
        {
            gameManager.ComerBananaMala();
            Destroy(otroObjeto.gameObject);
        }
        else if (otroObjeto.CompareTag("Basura"))
        {
            gameManager.ComerBasura();
            Destroy(otroObjeto.gameObject);
        }
    }
}