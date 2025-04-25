// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Scripts : MonoBehaviour
// {
//     public Rigidbody rigidBody;
//     public float Force=20f;
//     public float speed=40f;
//     void Start(){
//         rigidBody = GetComponent<Rigidbody>();
//     }
//     void FixedUpdate(){
//         Movement();
//     }
//     void Movement(){
//         if(Input.GetKey("w")){
//             rigidBody.AddForce(-Force,0f,0f*speed,ForceMode.Acceleration);
//         }
//         if(Input.GetKey("a")){
//             rigidBody.AddForce(0f,0f,-Force*speed,ForceMode.Acceleration);
//         }
//         if(Input.GetKey("s")){
//             rigidBody.AddForce(Force,0f,0f*speed,ForceMode.Acceleration);
//         }
//         if(Input.GetKey("d")){
//             rigidBody.AddForce(0f,0f,Force*speed,ForceMode.Acceleration);
//         }
        
//     }

// }
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ) * moveSpeed;
        rb.AddForce(moveDirection);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
