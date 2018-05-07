using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rigidbody;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update () {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) {
            rigidbody.AddRelativeForce(Vector3.up);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.add
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
        }
    }
}
