using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player2 : MonoBehaviour
{


    public float Playerspeed = 2.0f;
    Rigidbody rb;
    private bool Canjump = true;
    public float JumpPower = 2.5f;
    public GameObject GameOver;
    public cameramovement POV;
    [SerializeField] GameOverScreen deathMenu;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        GameOver.SetActive(false);
    }



    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 moveRelative = transform.TransformDirection(move) * Playerspeed * Time.deltaTime;

        rb.MovePosition(rb.position + moveRelative);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.Space) && Canjump == true)
        {
            rb.velocity = new Vector3(rb.velocity.x, JumpPower, rb.velocity.z);
            Canjump = false;

        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Map"))
        {
            Canjump = true;
        }

      if (collision.gameObject.CompareTag("Kill"))
      {

            deathMenu.ActiveScreenLose();
        }
    }
}
