using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public PlayerCollect playerCollect;
    public GameObject closedDoor;

    void Update()
    {
        if (playerCollect.ItemQuant >= 15)
        {
            closedDoor.SetActive(false);
        }
    }
}

