using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InicioController : MonoBehaviour
{
    public GameObject canvasInicio;
    public GameObject canvasJugador;
    public GameObject canvasHistoria;
    public GameObject selectPj;
    public GameObject ni�o1;
    public GameObject ni�o2;
    public GameObject ni�a1;
    public GameObject ni�a2;
    public GameObject confirmationSelectPj;
    private Sprite sprite;
    public GameObject selectedPj;
    public GameObject selectedPj2;
    private Image image;
    private Image image2;
    public GameObject presentacion;
    public GameObject seleccionarPais;
    public GameObject paisBrazil;
    public GameObject paisArgentina;
    public GameObject controls;


    private void Start()
    {
        canvasInicio.SetActive(true);
        canvasJugador.SetActive(false);
        canvasHistoria.SetActive(false);
    }

    public void StartGame()
    {
        canvasInicio.SetActive(false);
        canvasJugador.SetActive(true);
    }

    public void PjSelected(int ni�o)
    {
      
        if (ni�o == 0)
        {
            sprite = ni�o1.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        else if (ni�o ==1){
            sprite = ni�o2.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        else if( ni�o == 2)
        {
            sprite = ni�a1.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        else if (ni�o == 3)
        {
            sprite = ni�a2.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        selectPj.SetActive(false);
        confirmationSelectPj.SetActive(true);
    }

    public void noSelected()
    {
        selectPj.SetActive(true);
        confirmationSelectPj.SetActive(false);
        GlobalGameController.instance.SetPersonaje(null);
    }

    public void introHistoria()
    {
        canvasJugador.SetActive(false);
        canvasHistoria.SetActive(true);
    }

    public void SeleccionarPais()
    {
        presentacion.SetActive(false);
        seleccionarPais.SetActive(true);
    }

    public void Brazil()
    {
        seleccionarPais.SetActive(false);
        paisBrazil.SetActive(true);
    }
    public void Argentina()
    {
        seleccionarPais.SetActive(false);
        paisArgentina.SetActive(true);
    }

    public void ControlBrazil()
    {
        paisBrazil.SetActive(false);
        controls.SetActive(true);
    }

    public void ControlArgentina()
    {
        paisArgentina.SetActive(false);
        controls.SetActive(true);
    }

    public void IniciarJuego()
    {
        SceneManager.LoadScene("MapaBrasil");
    }

  
}
