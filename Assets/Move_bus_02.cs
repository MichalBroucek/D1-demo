﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_bus_02 : MonoBehaviour
{
    public float forwardForce = 1000f;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        Debug.Log("Move script initialized ...");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
}