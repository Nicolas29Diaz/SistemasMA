using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonInteractivo : MonoBehaviour
{
    public bool interactMode = false;
    public GameObject interactableObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (interactMode && Input.GetKeyDown(KeyCode.E))
        {
            if (interactMode)
            {
                StartMinigame(interactableObject.GetComponent<MiniGameInteractiveArea>().SpawnMinigame.transform,
                    interactableObject.GetComponent<MiniGameInteractiveArea>().TileMapMinigame,
                    interactableObject.GetComponent<MiniGameInteractiveArea>().ActualTileMap);
            }
        }
    }

    public void StartMinigame(Transform spawn, GameObject minigameTilemap, GameObject actualTilemap)
    {
        interactableObject.GetComponent<MiniGameInteractiveArea>().isStart = true;
        transform.position = spawn.position;
        actualTilemap.SetActive(false);
        minigameTilemap.SetActive(true);

    }

    public void EndMinigame(Transform lastPosition, GameObject mapTilemap, GameObject minigameTilemap)
    {
        transform.position = lastPosition.position;
        minigameTilemap.SetActive(false);
        mapTilemap.SetActive(true);
    }
}
