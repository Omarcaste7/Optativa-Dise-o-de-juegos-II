using UnityEngine;
using UnityEngine.EventSystems; // ¡Importante para detectar el arrastre!

// Agregamos la interfaz IDragHandler para que Unity sepa que esto se puede mover
public class ArrastrarObjeto : MonoBehaviour, IDragHandler
{
    // Esta función se ejecuta automáticamente mientras mantienes el clic y mueves
    public void OnDrag(PointerEventData eventData)
    {
        // El objeto sigue la posición de tu puntero (mouse o dedo)
        transform.position = eventData.position;
    }
}