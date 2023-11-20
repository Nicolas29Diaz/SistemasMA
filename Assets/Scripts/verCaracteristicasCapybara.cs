using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verCaracteristicasCapybara : MonoBehaviour
{
    [SerializeField] private GameObject caracteristicasCapybara;

    [SerializeField] private GameObject jugador;

    [SerializeField] PlayerMovement movimientoJugador;

    public bool escenaTigre = false;
    public string playerName;
    void Start()
    {
        playerName = GlobalGameController.instance.GetPjSelected();
        movimientoJugador = GameObject.Find(playerName).GetComponent<PlayerMovement>();
        jugador = GameObject.Find(playerName);
    }

    //private void Awake()
    //{
    //    playerName = GlobalGameController.instance.GetPjSelected();
    //    movimientoJugador = GameObject.Find(playerName).GetComponent<PlayerMovement>();
    //    jugador = GameObject.Find(playerName);
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
       

        if(collision.transform.name == (playerName))
        {
            if (escenaTigre)
            {
                jugador.SetActive(false);
            }
            caracteristicasCapybara.SetActive(true);
            

            // Verifica si el componente fue encontrado
            if (movimientoJugador != null)
            {
                // Aquí puedes acceder a las variables y métodos públicos de pm
                // Por ejemplo, para desactivar el script playerMovement:
                movimientoJugador.enabled = false;
            }
        }
    }

    public void alejarYReactivar()
    {

        Vector3 nuevaPosicion = jugador.transform.position;
        nuevaPosicion.y += 5;
        jugador.transform.position = nuevaPosicion;
        movimientoJugador.enabled = true;
        caracteristicasCapybara.SetActive(false);
    }

    public void DesactivarPlayer()
    {
        playerName = GlobalGameController.instance.GetPjSelected();
        movimientoJugador = GameObject.Find(playerName).GetComponent<PlayerMovement>();
        jugador = GameObject.Find(playerName);

        jugador.SetActive(false);
    }
    

    // Update is called once per frame
    void Update()
    {
     
    }
}
