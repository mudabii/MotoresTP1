using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombTrow : MonoBehaviour
{
    [Header("References")]
    public Transform cam;
    public Transform attPoint;
    public GameObject bombPrefab;

    [Header("Settings")]
    public float throwCD;

    [Header("Trowing")]
    public KeyCode throwKey = KeyCode.Mouse0;
    public float throwForce;
    public float ThrowUpwardForce;

    bool readyToThrow;

    private void Start()
    {
        readyToThrow = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(throwKey) && readyToThrow)
        {
            Throw();
        }
    }

    private void Throw()
    {
        readyToThrow = false;

        GameObject projectile = Instantiate(bombPrefab, attPoint.position, cam.rotation);

        Rigidbody projectileRB =projectile.GetComponent<Rigidbody>();

        Vector3 forceToAdd = cam.transform.forward * throwForce + transform.up * ThrowUpwardForce;

        projectileRB.AddForce(forceToAdd, ForceMode.Impulse);

        Invoke(nameof(ResetThrow), throwCD);
    }

    private void ResetThrow() 
    {
        readyToThrow = true;
    }
}
