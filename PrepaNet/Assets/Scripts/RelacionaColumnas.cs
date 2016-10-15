using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RelacionaColumnas : MonoBehaviour {
	
	public Text[] arrResp = new Text[6];
	public GameObject panel;

	//Se hicieron públicos porque BotonPanel los reinicializa a 0
	public int contIzq = 0;
	public int contDer = 0;

	//Inicializar arreglos
	string[,] colIzq = new string[,] { 
		{ "", "" }, { "", "" }, { "", "" }
	};
	string[,] colDer = new string[,] { 
		{ "", "" }, { "", "" }, { "", "" }
	};

	public void Start() {
		int slotIzq = (int)Random.Range (0.0f, 2.0f);
		int slotDer = (int)Random.Range (0.0f, 2.0f);
		int preguntaBuena = (int)Random.Range (0.0f, 2.0f);
		//Asignar pregunta a un slot
		colIzq [slotIzq, 0] = BancoRelacionar.bancoBuenas [preguntaBuena, 0];
		colIzq [slotIzq, 1] = "si";
		colDer [slotDer, 0] = BancoRelacionar.bancoBuenas [preguntaBuena, 1];
		colIzq [slotDer, 1] = "si";

		int preguntaMala1 = (int)Random.Range (0.0f, 5.0f);
		int preguntaMala2 = (int)Random.Range (0.0f, 5.0f);
		//Asegurarse que no sea la misma pregunta
		while (preguntaMala1 == preguntaMala2) {
			preguntaMala2 = (int)Random.Range (0.0f, 5.0f);
		}

		//Asignar primer pregunta mala al izq
		AsignarPreguntas(colIzq, BancoRelacionar.bancoMalas [preguntaMala1, 0]);
		//Asignar segunda pregunta mala al izq
		AsignarPreguntas(colIzq, BancoRelacionar.bancoMalas [preguntaMala2, 0]);
		//Asignar primer pregunta mala al der
		AsignarPreguntas (colDer, BancoRelacionar.bancoMalas [preguntaMala1, 1]);
		//Asignar segunda pregunta mala al der
		AsignarPreguntas (colDer, BancoRelacionar.bancoMalas [preguntaMala2, 1]);

		//Asignar el texto correspondiente
		for (int j = 0; j < 3; j++) {
			arrResp [j].GetComponent<Text> ().text = colIzq [j, 0];
		}

		for (int j = 3; j < 6; j++) {
			arrResp [j].GetComponent<Text> ().text = colDer [j - 3, 0];
		}
	}

	void AsignarPreguntas (string[,] arreglo, string preg) {
		int i = 0;
		bool salir = false;
		while (i < 3 && !salir) {
			if (arreglo[i, 0] == "") {
				arreglo [i, 0] = preg;
				arreglo [i, 1] = "no";
				salir = true;
			}
			i++;
		}
	}

	public void Validar() {
		ValidarColumnaIzquierda ();
		ValidarColumnaDerecha ();
		bool entra = panel.activeSelf;
		print (entra);
		/*
		if (entra) {

		//print ("Antes del if");
		//if (!panel.activeSelf) {
			print ("Entro al if");
			string respIzq = "";
			string respDer = "";
			int i = 0;
			while (i < 3) {
				if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState)
					respIzq = colIzq [i, 1];
			}
			print ("Salio del primer while");
			i = 3;
			while (i < 6) {
				if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState)
					respDer= colDer [i - 3, 1];
			}

			print ("Salio del segundo while");

			if (respIzq == "si" && respDer == "si") {
				print ("Bien");
			} else {
				print ("Mal");
			}
		}
		*/

	}

	private void ValidarColumnaIzquierda() {
		for (int i = 0; i < 3; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState)
				contIzq++;
		}

		if (contIzq > 1 || contIzq < 1) {
			panel.SetActive (true);
		}
	}

	private void ValidarColumnaDerecha() {
		for (int i = 3; i < 6; i++) {
			if (arrResp [i].GetComponent<SeleccionaRespuesta> ().clickState)
				contDer++;
		}

		if (contDer > 1 || contDer < 1) {
			panel.SetActive (true);
		}
	}

}
