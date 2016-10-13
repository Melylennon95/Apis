using UnityEngine;
using System.Collections;

public class BotonPanel : MonoBehaviour {

	public GameObject panel;
	public GameObject respuestas;

	public void QuitarPanel() {
		panel.SetActive (false);
		respuestas.GetComponent<RelacionaColumnas> ().contDer = 0;
		respuestas.GetComponent<RelacionaColumnas> ().contIzq = 0;
	}
}
