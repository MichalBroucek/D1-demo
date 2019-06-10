using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_taxi_rev : MonoBehaviour
{
    public float forwardForce = -10f;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Move rev script initialized ...");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce);
    }
}