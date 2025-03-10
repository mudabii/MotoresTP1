using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTrigger : MonoBehaviour
{
    public PlayerCollect playerCollect;
    public void OnTriggerEnter(Collider other)
    {
        if (playerCollect.ItemQuant >= 15)
        {
            SceneManager.LoadScene(3);
        }
    }
}
