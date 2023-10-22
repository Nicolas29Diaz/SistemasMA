using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGameInteractiveArea : MonoBehaviour
{
    public GameObject TileMapMinigame;
    public GameObject ActualTileMap;
    public Transform SpawnMinigame;
    private Transform LastPosition;
    public bool isStart;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<BotonInteractivo>().interactMode = true;
            collision.GetComponent<BotonInteractivo>().interactableObject = this.gameObject;
            LastPosition = collision.transform;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<BotonInteractivo>().interactMode = false;
            LastPosition = null;
            isStart = false;
        }
    }
}
