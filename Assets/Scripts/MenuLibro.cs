using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuLibro : MonoBehaviour
{
    public GameObject libro;
    public GameObject general;
    public GameObject especifico;
    public GameObject pagina1_2;
    public GameObject pagina3_4;
    public GameObject pagina5_6;

    public GameObject botonPaginaSiguiente;
    public GameObject botonPaginaAnterior;


    private bool libroAbierto = false;
    private bool generalAbierto = true;
    private bool especificoAbierto = false;

    private int index = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ControlPaginas();
    }

    public void AbrirLibro()
    {
        if (libroAbierto == false)
        {
            libro.SetActive(true);
            libroAbierto = true;

            Time.timeScale = 0;
        }
    }

    public void CerrarLibro()
    {


        libro.SetActive(false);
        libroAbierto = false;

        Time.timeScale = 1;

    }


    public void AbrirGeneralCerrarEspecifico()
    {
        if (generalAbierto == false)
        {
            general.SetActive(true);
            generalAbierto = true;
            especifico.SetActive(false);
            especificoAbierto = false;
        }
    }


    public void CerrarGeneralAbrirEspecifico()
    {
        if (especificoAbierto == false)
        {
            especifico.SetActive(true);
            especificoAbierto = true;
            general.SetActive(false);
            generalAbierto = false;

        }
    }

    public void PaginaSiguiente()
    {
        if (index == 2)
        {
            index = 2;
        }
        else
        {
            index++;
        }
    }

    public void PaginaAnterior()
    {
        if (index == 0)
        {
            index = 0;
        }
        else
        {
            index--;
        }
    }
    private void ControlPaginas()
    {
        switch (index)
        {
            case 0:
                pagina1_2.SetActive(true);
                pagina3_4.SetActive(false);
                pagina5_6.SetActive(false);
                botonPaginaAnterior.GetComponent<Button>().interactable = false;
                botonPaginaSiguiente.GetComponent<Button>().interactable = true;
                break;
            case 1:
                pagina3_4.SetActive(true);
                pagina1_2.SetActive(false);
                pagina5_6.SetActive(false);
                botonPaginaAnterior.GetComponent<Button>().interactable = true;
                botonPaginaSiguiente.GetComponent<Button>().interactable = true;

                break;
            case 2:
                pagina5_6.SetActive(true);
                pagina3_4.SetActive(false);
                pagina1_2.SetActive(false);
                botonPaginaSiguiente.GetComponent<Button>().interactable = false;

                break;
            default:
                pagina1_2.SetActive(true);
                pagina3_4.SetActive(false);
                pagina5_6.SetActive(false);
                botonPaginaAnterior.GetComponent<Button>().interactable = false;
                break;
        }

    }
}

