using UnityEngine;
using System.Collections;

public class eleccion : MonoBehaviour {

	public GameObject miCube;
	public GameObject global;
	public float cont = 0.0f;
	public bool pulsado = false;

	public void empezarAnimacion()
	{
		pulsado = true;
		global.GetComponent<Animator> ().enabled = false;
		miCube.GetComponent<Animator> ().enabled = true;


	}

	void Update()
	{
		if (pulsado == true)
			cont++;

		if (cont > 120) 
		{
			pulsado = false;
			cont = 0;
			Application.LoadLevel("escena2");
		}
	}
}
