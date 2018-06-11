using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(paddleSpeed * Time.deltaTime * Input.GetAxis("Horizontal"), 0, 0);
        float xPosition = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        var position = transform.position;
        position.x = Mathf.Clamp(xPosition, -6.8f, 6.8f);
        transform.position = position;
    }
}
