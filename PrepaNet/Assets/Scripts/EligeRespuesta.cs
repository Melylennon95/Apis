using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EligeRespuesta : MonoBehaviour {

	public Text[] arrResp = new Text[5];
	public GameObject panel;

	public int contResp = 0;

	//Inicializar arreglo
	string[,] resp = new string[,] { 
		{ "", "" }, { "", "" }, { "", "" }, { "", "" }
	};

	// Use this for initialization
	void Start () {

		int slotBuena = (int)Random.Range (0.0f, 3.0f);
		int preguntaBuena = (int)Random.Range (0.0f, 1.0f);

		//Escribir la pregunta en el título
		arrResp[0].GetComponent<Text>().text = BancoPreguntas.buenasElige[preguntaBuena, 0];
		resp [slotBuena, 0] = BancoPreguntas.buenasElige [preguntaBuena,1];
		resp [slotBuena, 1] = "si";

		int preguntaMala1 = (int)Random.Range (0.0f, 5.0f);
		int preguntaMala2 = (int)Random.Range (0.0f, 5.0f);
		//Asegurarse que no sean la misma
		while (preguntaMala2 == preguntaMala1) {
			preguntaMala2 = (int)Random.Range (0.0f, 5.0f);
		}
		int preguntaMala3 = (int)Random.Range (0.0f, 5.0f);
		while (preguntaMala3 == preguntaMala1 || preguntaMala3 == preguntaMala2) {
			preguntaMala3 = (int)Random.Range (0.0f, 5.0f);
		}

		//Asignar las respuestas erroneas en los espacios desocupados
		AsignarPreguntas(resp, BancoPreguntas.malasElige[preguntaMala1]);
		AsignarPreguntas(resp, BancoPreguntas.malasElige[preguntaMala2]);
		AsignarPreguntas(resp, BancoPreguntas.malasElige[preguntaMala3]);

		print ("0" + resp [0, 0]);
		print ("1" + resp [1, 0]);
		print ("2" + resp [2, 0]);
		print ("3" + resp [3, 0]);

		//Cambiar el texto de las preguntas
		for (int i = 1; i < arrResp.Length; i++) {
			arrResp [i].GetComponent<Text> ().text = resp [i - 1, 0];
		}
	}

	void AsignarPreguntas (string[,] arreglo, string preg) {
		int i = 0;
		bool salir = false;
		while (i < 4 && !salir) {
			if (arreglo [i, 0] == "") {
				arreglo [i, 0] = preg;
				arreglo [i, 1] = "no";
				salir = true;
			}
			i++;
		}
	}
}
