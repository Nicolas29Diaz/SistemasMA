using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoGuazu : MonoBehaviour
{
    public GameObject canvasInfo;
    public GameObject tilemapMapa;
    public GameObject player;
    public GameObject guazu;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tilemapMapa.SetActive(false);
            canvasInfo.SetActive(true);
            player.SetActive(false);
        }
    }

    public void ApagarInfo()
    {
        tilemapMapa.SetActive(true);
        canvasInfo.SetActive(false);
        player.SetActive(true);

        guazu.GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
