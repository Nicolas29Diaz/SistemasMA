using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePlayer : MonoBehaviour
{
    public GameObject player;
    private string playerName;
    private void Awake()
    {
        playerName = GlobalGameController.instance.GetPjSelected();
        player = GameObject.Find(playerName);
    }

    private void Start()
    {
        playerName = GlobalGameController.instance.GetPjSelected();
        player = GameObject.Find(playerName);
    }

    public void DesactivarPlayer()
    {
        player.SetActive(false);
    }
}
