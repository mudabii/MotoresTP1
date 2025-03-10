using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{
    public int dmg;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<BreakWall>() != null)
        {
            BreakWall breakWall = collision.gameObject.GetComponent<BreakWall>();
            breakWall.TakeDmg(dmg);
            Destroy(gameObject);
        }
    }
}
