using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verCaracteristicasCapybara : MonoBehaviour
{
    [SerializeField] private GameObject caracteristicasCapybara;

    [SerializeField] private GameObject jugador;

    [SerializeField] PlayerMovement movimientoJugador;
    public string playerName;

    private void Awake()
    {
        //playerName = GlobalGameController.instance.GetPjSelected();

        Transform primerHijoActivo = EncontrarPrimerHijoActivo(jugador.transform);

        movimientoJugador = primerHijoActivo.GetComponent<PlayerMovement>();
        //jugador = GameObject.Find(playerName);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
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

        Transform primerHijoActivo = EncontrarPrimerHijoActivo(jugador.transform);
        Vector3 nuevaPosicion = jugador.transform.position;
        nuevaPosicion.y += 5;
        jugador.transform.position = nuevaPosicion;

        primerHijoActivo.GetComponent<PlayerMovement>().enabled = true;
        //movimientoJugador.enabled = true;
        caracteristicasCapybara.SetActive(false);
    }

    public void DesactivarPlayer()
    {
        Transform primerHijoActivo = EncontrarPrimerHijoActivo(jugador.transform);

        //playerName = GlobalGameController.instance.GetPjSelected();
        movimientoJugador = GameObject.Find(playerName).GetComponent<PlayerMovement>();
        jugador = GameObject.Find(playerName);

        jugador.SetActive(false);
    }

    private Transform EncontrarPrimerHijoActivo(Transform padre)
    {
        // Recorre los hijos del padre
        for (int i = 0; i < padre.childCount; i++)
        {
            Transform hijo = padre.GetChild(i);

            // Verifica si el hijo está activo
            if (hijo.gameObject.activeSelf)
            {
                return hijo; // Retorna el primer hijo activo
            }
        }

        return null; // Retorna null si no se encuentra ningún hijo activo
    }


    // Update is called once per frame
    void Update()
    {
     
    }
}
