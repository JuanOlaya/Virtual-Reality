using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowBehaviour : MonoBehaviour {

    public Material HighLightMaterial;

    private Renderer myRenderer;
    private Material normalMaterial;

	void Start () {
        this.myRenderer = GetComponent<Renderer>();
        this.normalMaterial = this.myRenderer.material;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HighLight()
    {
       // myRenderer.material = HighLightMaterial;
    }

    public void NormalRendering ()
    {
       // myRenderer.material = normalMaterial;
    }
}
