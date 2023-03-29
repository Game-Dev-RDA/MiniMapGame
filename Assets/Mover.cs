using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    float vertical, horizontal;
    Rigidbody2D myRigidBody2D;

    void Start()
    {
        myRigidBody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }

    void MoveBall()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        myRigidBody2D.velocity = new Vector2(horizontal*moveSpeed, vertical*moveSpeed);
    }
}
