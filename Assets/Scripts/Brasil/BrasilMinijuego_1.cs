using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrasilMinijuego_1 : MonoBehaviour
{
    [SerializeField] MovimientosCamara MovCam;
    [SerializeField] GameObject Banana;
    [SerializeField] Sprite[] Preguntas;
    [SerializeField] Transform[] QuizBananaPositions;
    [SerializeField] Transform[] RecolectBananaPositions;
    [SerializeField] Camera cam;
    int MinigameState = 0;
    int RespuestaCorrecta = 0;
    MiniGameInteractiveArea InteractiveArea;

    private void Start()
    {
        InteractiveArea = GetComponent<MiniGameInteractiveArea>();
    }
    private void Update()
    {
        Debug.Log(RecolectBananaPositions[1]);
        if (InteractiveArea.isStart && MinigameState == 2)
        {
            QuizGame();
        }
    }

    public void QuizGame()
    {
        MovCam.ChangeCameraPosition(0);
        int i = 0;
        foreach (Transform t in QuizBananaPositions)
        {
            GameObject p = Instantiate(Banana, t);
            p.GetComponent<BananasMovimiento>().SetNum(i+1, cam);
            p.transform.SetParent(transform, false);
            i++;
        }
    }

    public void EndGame()
    {
        MovCam.ChangeCameraPosition(0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Banana")
        {
            //collision.GetComponent<BananasMovimiento>().id;
        }
    }

}
