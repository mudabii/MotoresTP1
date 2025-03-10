using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombLifetime : MonoBehaviour
{
    [SerializeField] public float lifeTime = 3f;
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }
}
