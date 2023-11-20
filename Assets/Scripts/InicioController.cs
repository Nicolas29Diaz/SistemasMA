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
    public GameObject niño1;
    public GameObject niño2;
    public GameObject niña1;
    public GameObject niña2;
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

    public void PjSelected(int niño)
    {
      
        if (niño == 0)
        {
            sprite = niño1.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        else if (niño ==1){
            sprite = niño2.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        else if( niño == 2)
        {
            sprite = niña1.GetComponent<Image>().sprite;
            GlobalGameController.instance.SetPersonaje(sprite);
            image = selectedPj.GetComponent<Image>();
            image.sprite = GlobalGameController.instance.GetPersonaje();
            image2 = selectedPj2.GetComponent<Image>();
            image2.sprite = GlobalGameController.instance.GetPersonaje();
        }
        else if (niño == 3)
        {
            sprite = niña2.GetComponent<Image>().sprite;
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
