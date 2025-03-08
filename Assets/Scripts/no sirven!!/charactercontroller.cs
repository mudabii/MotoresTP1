using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactercontroller : MonoBehaviour
{
    private CharacterController controller;
    private bool groundedPlayer;
    private Vector3 PlayerVelocity;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && PlayerVelocity.y < 0)
        {
            PlayerVelocity.y = 0;
        }
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;

            if (Input.GetButtonDown("Jump") && groundedPlayer)
            {
                PlayerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);


            }
        }
        PlayerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(PlayerVelocity * Time.deltaTime);
    }
}
