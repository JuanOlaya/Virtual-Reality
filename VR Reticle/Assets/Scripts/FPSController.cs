using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

	public float speed = 2.0f;
	public float sensitivity = 2.0f;
	private CharacterController player;

	public GameObject eyes;

	float moveFB;
	float moveLR;

	float rotX;
	float rotY;

	void Start () 
	{
		//player = GetComponent<CharacterController> ();
	}

	void Update () 
	{
		
		Movement ();
	}

	void Movement()
	{
		rotX = Input.GetAxis ("Mouse X") * sensitivity;
		rotY = Input.GetAxis ("Mouse Y") * sensitivity;

		transform.Rotate (0,rotX,0);
		eyes.transform.Rotate (-rotY, 0, 0);
	}
}