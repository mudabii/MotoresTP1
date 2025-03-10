using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public GameObject Explosion;

    [Header("Stats")]
    public int health;
    public void TakeDmg(int dmg)
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        health -= dmg;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
