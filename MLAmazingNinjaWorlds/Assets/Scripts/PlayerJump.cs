using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpStrength = 10f;

    public float fallMultiplier = 2.5f;
    public float jumpMultiplier = 2f;

    public bool alwaysJumping = false;

    private bool canJump;

    private Rigidbody rigidBody;

    void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidBody.velocity.y == 0)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if (Input.GetButtonDown("Jump") && canJump)
        {
            GetComponent<Rigidbody>().velocity = Vector3.up * jumpStrength;

        }

        if (rigidBody.velocity.y < 0)
        {
            rigidBody.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rigidBody.velocity.y > 0 && !Input.GetButtonDown("Jump"))
        {
            rigidBody.velocity += Vector3.up * Physics.gravity.y * (jumpMultiplier - 1) * Time.deltaTime;
        }

    }
}
