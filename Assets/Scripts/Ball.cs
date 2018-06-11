using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballIntVol = 600f;
    private bool ballInPlay;
    private Rigidbody rb;
    

	// Use this for initialization
	void Awake ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballIntVol, ballIntVol, 0));
        }
        if (ballInPlay == true)
        {
            
        }
	}
    
}
