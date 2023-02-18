using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Default Down Speed")]
    //downward speed of the object
    public float downSpeed = 20f;
    [Header("Default Movement Speed")]
    //movement speed of the object
    public float movementSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    //movement direction of the object
    public float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //variable equals to component Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement equals horizontal movement * movement speed
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //if direction on x axis is less than 0
        if (movement < 0)
        {
            //object faces to the left
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        //if direction on x axis is greater than 0
        else
        {
            //object faces to the right
            this.GetComponent<SpriteRenderer>().flipX = (true);
        }
    }

    //Fixedupdate called every fixed fram rate frame
    private void FixedUpdate()
    {
        //Vector2 which is (x,y) velocity equals to the velocity of the rigidbody2d
        Vector2 velocity = rb.velocity;
        //velocity of x axis equals to direction movement on x axis of character
        velocity.x = movement;
        //rigidbody2d velocity equals to velocity of object
        rb.velocity = velocity;
    }
    //collision function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //velocity with downspeed
        rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
    }
}
