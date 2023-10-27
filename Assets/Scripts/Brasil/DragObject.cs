using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
 
    // Update is called once per frame
    private bool estaSiendoArrastrado = false;
    private Vector3 offset;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 representa el botón izquierdo del mouse
        {
            Debug.Log("si");
            // Rayo para detectar si el mouse hizo clic en el objeto
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    estaSiendoArrastrado = true;
                    offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                }
            }
        }

        if (estaSiendoArrastrado && Input.GetMouseButton(0))
        {
            Vector3 posicionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(posicionMouse.x + offset.x, posicionMouse.y + offset.y, transform.position.z);
        }

        if (estaSiendoArrastrado && Input.GetMouseButtonUp(0))
        {
            estaSiendoArrastrado = false;
        }
    }
}
