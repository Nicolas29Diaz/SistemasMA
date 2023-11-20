using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPersonaje : MonoBehaviour
{
    public GameObject ni�o1;
    public GameObject ni�o2;
    public GameObject ni�a1;
    public GameObject ni�a2;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        if(GlobalGameController.instance != null)
        {
            if (GlobalGameController.instance.GetPjSelected() == "PlayerNi�o1")
            {
                ni�o1.SetActive(true);
            }
            else if(GlobalGameController.instance.GetPjSelected() == "PlayerNi�o2")
            {
                ni�o2.SetActive(true);
            }
            else if (GlobalGameController.instance.GetPjSelected() == "PlayerNi�a1")
            {
                ni�a1.SetActive(true);
            }
            else if (GlobalGameController.instance.GetPjSelected() == "PlayerNi�a2")
            {
                ni�a2.SetActive(true);
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
