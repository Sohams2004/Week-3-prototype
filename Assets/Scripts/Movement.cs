using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10f;

    [SerializeField] public Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float inputx = Input.GetAxis("Horizontal");
        float inputz = Input.GetAxis("Vertical");

        Vector3 moveDirection = (transform.forward * inputz + transform.right * inputx) * movementSpeed * Time.deltaTime;
        playerRb.velocity = new(moveDirection.x, playerRb.velocity.y, moveDirection.z);
    }
}
