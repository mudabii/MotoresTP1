using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCollect playerCollect = other.GetComponent<PlayerCollect>();

        if (playerCollect != null)
        {
            playerCollect.ItemCollected();
            gameObject.SetActive(false);
        }
    }
}
