using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActivity : MonoBehaviour
{
    [Header("Canvas")]
    public GameObject canvasPreguntas;
    public GameObject canvasOsorio;
    public GameObject panelInfo;
    public GameObject panelDespues;

    [Header("Tilemaps")]
    public GameObject tilemapMapa;
    public GameObject tilemapActividad;

    [Header("GameObjects")]
    public GameObject triggerActividad;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tilemapMapa.SetActive(false);
            player.SetActive(false);

            canvasOsorio.SetActive(true);
            tilemapActividad.SetActive(true);

            triggerActividad.SetActive(false);
        }
    }

    public void ActivarPreguntas()
    {
        canvasPreguntas.SetActive(true);
        canvasOsorio.SetActive(false);
    }

    public void ActivarInfo()
    {
        panelDespues.SetActive(false);
        panelInfo.SetActive(true);
    }

    public void ActivarMapa()
    {
        canvasOsorio.SetActive(false);
        tilemapMapa.SetActive(true);
        tilemapActividad.SetActive(false);
        player.SetActive(true);
    }
}
