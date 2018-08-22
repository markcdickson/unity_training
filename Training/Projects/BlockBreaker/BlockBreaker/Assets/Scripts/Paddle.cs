using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenMaxX = 14.5f;
    [SerializeField] float screenMinX = 1.0f;
    [SerializeField] float screenSize = 16.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
        float xPosition = (Input.mousePosition.x / Screen.width) * screenSize;

        paddlePosition.x = Mathf.Clamp(xPosition, screenMinX, screenMaxX);
        transform.position = paddlePosition;
	}
}
