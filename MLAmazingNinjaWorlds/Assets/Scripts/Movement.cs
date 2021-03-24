using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed;

    private float masterSpeed;

    private bool grounded;

    void Awake()
    {
        masterSpeed = speed;
        grounded = GetComponentInParent<PlayerController>().onGround;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");


            //Rigidbody rigidBody;
            //rigidBody = GetComponent<Rigidbody>();
            //float verticalMovement = rigidBody.velocity.y;
            //if (!grounded)
            //{
            //    speed = masterSpeed / 3;
            //}
            //else if(grounded)
            //{
            //    speed = masterSpeed;
            //}


        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement * Time.deltaTime * speed;
    }
}
