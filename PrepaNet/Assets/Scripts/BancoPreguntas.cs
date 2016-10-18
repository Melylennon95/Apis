using UnityEngine;
using System.Collections;

public class BancoPreguntas : MonoBehaviour {

	public static string[,] buenasColumnas = new string[,] {
		{"H2O", "Agua"},
		{"FeO", "Oxido Ferroso"},
		{"NaCl", "Sal"}
	};

	public static string[,] malasColumnas = new string[,] {
		{ "Basket", "Fut" },
		{ "Americano", "Golf" },
		{ "Boliche", "Frisbee" },
		{ "Judo", "Karate" },
		{ "Esgrima", "Clavados" },
		{ "Canotaje", "Voleibol" }
	};

	public static string[,] buenasElige = new string[,] {
		{"¿Quién es la maestra de APIS?", "Jackeline"},
		{"¿Quien es el cliente?", "PrepaNet"}
	};

	public static string[] malasElige = new string[] {
			"Wicho", 
			"Mejorado", 
			"Raul Esparza", 
			"Elda Quiroga", 
			"Román", 
			"Yolanda"
	};
}
