using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPersonaje : MonoBehaviour
{
    public GameObject niño1;
    public GameObject niño2;
    public GameObject niña1;
    public GameObject niña2;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if(GlobalGameController.instance != null)
        {
            if (GlobalGameController.instance.GetPjSelected() == "PlayerNiño1")
            {
                niño1.SetActive(true);
            }
            else if(GlobalGameController.instance.GetPjSelected() == "PlayerNiño2")
            {
                niño2.SetActive(true);
            }
            else if (GlobalGameController.instance.GetPjSelected() == "PlayerNiña1")
            {
                niña1.SetActive(true);
            }
            else if (GlobalGameController.instance.GetPjSelected() == "PlayerNiña2")
            {
                niña2.SetActive(true);
            }
            else
            {

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
