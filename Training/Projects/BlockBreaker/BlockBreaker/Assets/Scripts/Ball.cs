using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    // Configuration Parameters
    [SerializeField] Paddle paddle;
    [SerializeField] float xPush = 2.0f;
    [SerializeField] float yPush = 15.0f;

    // State
    Vector2 ballPaddleDiff;
    Boolean hasStarted = false;

    // Use this for initialization
    void Start () {
        ballPaddleDiff = transform.position - paddle.transform.position;
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnClick();
        }
    }

    private void LaunchOnClick()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        Vector2 ballPosition = paddlePosition + ballPaddleDiff;
        transform.position = ballPosition;
    }
}
