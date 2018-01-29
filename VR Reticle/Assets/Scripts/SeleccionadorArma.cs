using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeleccionadorArma : MonoBehaviour {

	public int armaSeleccionada = 1;
	private Transform[] listaArmas;

	public int municionMax = 10;
	private int municionActual;
	public float tiempoDeRecarga = 1f;
	private bool estaRecargando=false;

	private Animator animator;


	void Start () 
	{
		animator = GetComponent<Animator>();

		listaArmas = this.GetComponentsInChildren<Transform>();
		listaArmas [1].gameObject.SetActive (true);
		listaArmas [2].gameObject.SetActive (false);
		listaArmas [3].gameObject.SetActive (false);

//		for (int i = 0; i < listaArmas.Length ; i++) 
//		{
//			Debug.Log ("Nombre: "+listaArmas [i].gameObject.name );
//		}
		municionActual = municionMax;

	}
	

	void Update () 
	{
		//Debug.Log (estaRecargando);
		//Debug.Log (municionActual);
		if (Input.GetKeyDown (KeyCode.Alpha1)) 
		{
			listaArmas [1].gameObject.SetActive (true);
			listaArmas [2].gameObject.SetActive (false);
			listaArmas [3].gameObject.SetActive (false);
			armaSeleccionada = 1;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) 
		{
			listaArmas [1].gameObject.SetActive (false);
			listaArmas [2].gameObject.SetActive (true);
			listaArmas [3].gameObject.SetActive (false);
			armaSeleccionada = 2;
		}

		if (Input.GetKeyDown (KeyCode.Alpha3)) 
		{
			listaArmas [1].gameObject.SetActive (false);
			listaArmas [2].gameObject.SetActive (false);
			listaArmas [3].gameObject.SetActive (true);
			armaSeleccionada = 3;
		}

		if (estaRecargando) 
		{
			return;
		}

		if (municionActual <= 0) 
		{
			
			StartCoroutine ( Recargar() );  //Recargar ();
			return;
		}

		if (Input.GetKeyDown (KeyCode.LeftControl)) 
		{
			Disparar ();
		}
	}

	IEnumerator Recargar()    // void Recargar()
	{
		estaRecargando = true;
		//Debug.Log ("Recargando ");
		animator.SetBool ("Reloding",true);

		yield return new WaitForSeconds (tiempoDeRecarga);

		animator.SetBool ("Reloding",false);

		municionActual = municionMax;
		estaRecargando = false;
	}

	void Disparar()
	{
		municionActual--;
	}
}
 