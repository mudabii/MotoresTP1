using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    
    public Vector3 newpos;
    public float speed;
    public Rigidbody rigidBody;

    public int coinscollected;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();

        transform.position = newpos;

    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Coin"))
            {
                Destroy(collision.gameObject);
                coinscollected++; 
            }
        }
    }
}