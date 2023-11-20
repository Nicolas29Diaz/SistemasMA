using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalGameController : MonoBehaviour
{

    public static GlobalGameController instance;

    [SerializeField] private string pjSelected;
    [SerializeField] private Sprite personaje;
    private void Awake()
    {

        if (GlobalGameController.instance == null)
        {
            GlobalGameController.instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void SetPjSelected(string pjSelectedName)
    {
        pjSelected = pjSelectedName;
    }
        
    public string GetPjSelected()
    {
        return pjSelected;  
    }

    public void SetPersonaje(Sprite pj)
    {
        personaje = pj;
    }
    public Sprite GetPersonaje()
    {
        return personaje;
    }
}
