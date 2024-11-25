using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Animator door = null;
    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                door.Play("dooropen", 0, 0.0f);
                gameObject.SetActive(false);
            }
            else if (closeTrigger)
            {
                door.Play("door close", 0, 0.0f);
                gameObject.SetActive(false);
            }

        }
    }
}