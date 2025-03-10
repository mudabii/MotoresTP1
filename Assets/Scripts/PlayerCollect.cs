using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class PlayerCollect : MonoBehaviour
{
    public int ItemQuant { get; private set; }
    public UnityEvent<PlayerCollect> OnItemCollected;
    public void ItemCollected()
    {
        ItemQuant++;
        OnItemCollected.Invoke(this);
    }
}
