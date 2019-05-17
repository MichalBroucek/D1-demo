using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_car_player : MonoBehaviour
{
    public float forwardForce = 1000f;
    public float sideForce = 250f;
    public Rigidbody rb;

//    public Joystick joystick;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Move script initialized ...");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Todo: move detection of Keyboard into Update() function
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //rb.velocity = new Vector3(
        //            joystick.Horizontal * 30f,
        //            rb.velocity.y,
        //            rb.velocity.z
        //            //joystick.Vertical * 30f
        //            );

        //if (rb.position.y < -1.5f)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
    }
}
