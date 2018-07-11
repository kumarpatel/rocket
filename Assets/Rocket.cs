using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {
    Rigidbody rigidbody;
	AudioSource audioSource;
    [SerializeField] float Thrust = 100f;
    [SerializeField] float MainThrust = 100f;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update () {
        ProcessInput();
    }

    private void ProcessInput()
    {
        float rotationThisFrame = Thrust * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow)) {
			if (!audioSource.isPlaying) {
				audioSource.Play();
			}
            rigidbody.AddRelativeForce(Vector3.up * MainThrust);
		} else {
			audioSource.Stop();
		}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
        }
    }
}
