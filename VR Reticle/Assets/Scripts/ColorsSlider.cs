using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorsSlider : MonoBehaviour {

	public float red, green, blue;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RedChanged(float value)
	{
		this.red = value;
		SetColor ();
	}

	public void SetColor()
	{
		GetComponent<Renderer> ().material.color = new Color (red,green,blue);
	}
}
