using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientosCamara : MonoBehaviour
{
    public Camera Cam;
    public Vector3[] CamPositions; // Coloca las posiciones de la c�mara aqu�

    public int currentCamPositionIndex = 0; // �ndice actual de la posici�n de la c�mara

    void Start()
    {
        Cam = GetComponent<Camera>();
        if (CamPositions.Length == 0)
        {
            Debug.LogWarning("No se han configurado posiciones de c�mara en CamPositions.");
        }
    }

    void Update()
    {
        // Aqu� puedes agregar l�gica para mover la c�mara, por ejemplo, en respuesta a la entrada del jugador.
        // Por ejemplo, puedes usar Input.GetKey o alg�n otro m�todo para cambiar la posici�n de la c�mara.
        if (Input.GetKeyDown(KeyCode.Space)) // Ejemplo: cambia la posici�n de la c�mara cuando se presiona la barra espaciadora.
        {

            ChangeCameraPosition(currentCamPositionIndex);
            // Avanzar al siguiente �ndice de posici�n de la c�mara (c�clicamente).
            currentCamPositionIndex = (currentCamPositionIndex + 1) % CamPositions.Length;
        }
    }

    public void ChangeCameraPosition(int IndexPosition)
    {
        if (CamPositions.Length == 0)
        {
            return; // No hay posiciones de c�mara configuradas.
        }

        

        Vector3 targetPosition = CamPositions[IndexPosition];
        transform.position = targetPosition;
    }
}
