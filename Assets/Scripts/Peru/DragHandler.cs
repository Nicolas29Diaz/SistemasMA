using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class DragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Vector3 startPosition;
    public GameObject targetObject; // Objeto al que quieres arrastrar el bot�n.
    public MinijuegoPeru_ArbolDeQuina scriptCanvas;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = transform.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position += (Vector3)eventData.delta; // Mueve el bot�n con el movimiento del rat�n.
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        // Comprobar si el bot�n est� sobre el objeto objetivo.
        if (RectTransformUtility.RectangleContainsScreenPoint(targetObject.GetComponent<RectTransform>(), Input.mousePosition))
        {
            // Llamar a la funci�n que deseas ejecutar.
            ExecuteAction();
        }
        transform.position = startPosition; // Devuelve el bot�n a su posici�n inicial.
    }

    private void ExecuteAction()
    {
        // Aqu� pones el c�digo de la acci�n que quieres que se ejecute.
        scriptCanvas.contador += 1;
        Debug.Log("Acci�n ejecutada!");
    }
}
