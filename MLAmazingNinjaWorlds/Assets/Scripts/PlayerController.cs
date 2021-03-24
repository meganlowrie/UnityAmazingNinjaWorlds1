using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Animator animatorClip;

    public string runningParameter = "Running";
    public string inTheAirParameter = "OnGround";
    public string jumpingParameter = "JumpUp";
    public string fallingParameter = "JumpDown";
    public string jumpButtonPressed = "JumpStart";

    private Rigidbody rigidBody;

    private bool running;
    [SerializeField]
    public bool onGround;
    private bool jumping;
    private bool falling;
    private bool jumpStart;

    public float distanceGround;

    // Start is called before the first frame update
    void Start()
    {
        running = false;
        onGround = true;
        jumping = false;
        falling = false;
        jumpStart = false;
        rigidBody = GetComponent<Rigidbody>();
        animatorClip = GetComponent<Animator>();
        distanceGround = GetComponent<Collider>().bounds.extents.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        float verticalVelocity = rigidBody.velocity.y;
        if(!Physics.Raycast(transform.position, -Vector3.up, distanceGround + 0.5f))
        {
            onGround = false;
        } else
        {
            onGround = true;
        }

        if (verticalVelocity > 0.01f)
        {
            jumping = true;
            falling = false;
            running = false;
        }
        else if (verticalVelocity < -0.3f)
        {
            jumping = false;
            falling = true;
            running = false;

        }
        else
        {
            jumping = false;
            falling = false;
        }

        if (horizontal != 0 && onGround)
        {
            running = true;
        }
        else
        {
            running = false;
        }

        if (horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        else if (horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jumpStart = true;

        }
        else
        {
            jumpStart = false;
        }

        animatorClip.SetBool(runningParameter, running);
        animatorClip.SetBool(inTheAirParameter, onGround);
        animatorClip.SetBool(jumpingParameter, jumping);
        animatorClip.SetBool(fallingParameter, falling);
        animatorClip.SetBool(jumpButtonPressed, jumpStart);

    }

}
