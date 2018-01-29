using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 Tomado de :
 Rotate Camera with Mouse in Unity 3D
 https://www.youtube.com/watch?v=lYIRm4QEqro
*/

public class CameraMovement : MonoBehaviour {


	public float speedH = 2.0f;
	public float speedV = 2.0f;

	private float yaw = 0.0f;
	private float pitch = 0.0f;



	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		yaw += speedH * Input.GetAxis("Mouse X");
		pitch -= speedV * Input.GetAxis("Mouse Y");

		transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

	}
}

