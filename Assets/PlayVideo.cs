using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{

    public VideoPlayer videoPlayer; // Asigna el VideoPlayer desde el inspector
    public GameObject targetGameObject;
    public GameObject sourcePanel;
    public GameObject nextPanel;

    private void Start()
    {
        // Aseg�rate de que el VideoPlayer est� configurado correctamente
        if (videoPlayer == null)
        {
            Debug.LogError("El VideoPlayer no est� asignado en el inspector.");
            return;
        }

        // Desactiva el GameObject al principio
        if (targetGameObject != null)
        {
            targetGameObject.SetActive(false);
        }

        // Suscribirse al evento de finalizaci�n del video
        videoPlayer.loopPointReached += OnVideoEnd;
    }


    private void OnVideoEnd(VideoPlayer vp)
    {
        // Este m�todo se llama cuando el video llega al final

        // Puedes activar el GameObject al final del video
        if (targetGameObject != null)
        {
            targetGameObject.SetActive(true);
        }
    }

    public void SiguientePanel()
    {
        sourcePanel.SetActive(false);
        nextPanel.SetActive(true);
    }
}
