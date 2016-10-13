using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RelacionaColumnas : MonoBehaviour {
	
	public Text[] arrResp = new Text[6];
	public int contIzq = 0;
	public int contDer = 0;
	public GameObject panel;

	public void Validar() {
		ValidarColumnaIzquierda ();
		ValidarColumnaDerecha ();
	}

	private void ValidarColumnaIzquierda() {
		for (int i = 0; i < 3; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState)
				contIzq++;
		}

		if (contIzq > 1 || contIzq == 0)
			panel.SetActive (true);
	}

	private void ValidarColumnaDerecha() {
		for (int i = 3; i < 6; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState)
				contDer++;
		}
		if (contDer > 1 || contDer == 0)
			panel.SetActive (true);
	}

}
