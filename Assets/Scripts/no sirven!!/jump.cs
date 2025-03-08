using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumpForce = 5f; 
    private bool isGrounded = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Map")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Map")
        {
            isGrounded = false;
        }
    }

    void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
