using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player; // Variable refrences to a Transform comp
    //public float speed = 1.0f;
    public float forceMultiplier = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Any physics go with FixUp..
    void FixedUpdate()
    {
        // 3d Vector in space
        Vector3 moveDirection = Vector3.zero; // Direction of x axis

        float horizontalInput = Input.GetAxis("Horizontal");
        moveDirection += new Vector3(horizontalInput, 0, 0);

        float verticalInput = Input.GetAxis("Vertical");
        moveDirection += new Vector3(0, 0, verticalInput);

        //Vector3 moveDelta = moveDirection * (speed * Time.deltaTime); // direction * v * t = pos

        Vector3 movingForce = moveDirection * forceMultiplier;

        player.AddForce(movingForce);
    }
}

// Notes
// Unity serializes all public variables