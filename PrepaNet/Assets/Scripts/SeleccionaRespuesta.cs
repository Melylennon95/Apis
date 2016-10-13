using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SeleccionaRespuesta : MonoBehaviour{

	public bool clickState = false;

	public void changeState() {
		clickState = !clickState;
	}

		
}
