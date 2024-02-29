using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] float jumpForce, jumpHeight, gravityScale;
    [SerializeField] bool isGrounded;

    Movement movement;

    private void Start()
    {
        movement = FindObjectOfType<Movement>();
    }

    void Jump_()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            movement.playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (!isGrounded)
        {
            movement.playerRb.AddForce(Physics.gravity * (gravityScale - 1) * movement.playerRb.mass);
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }

    private void Update()
    {
        Jump_();
    }
}
