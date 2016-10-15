using UnityEngine;
using System.Collections;

public class BancoRelacionar : MonoBehaviour {

	public static string[,] bancoBuenas = new string[,] {
		{"H2O", "Agua"},
		{"FeO", "Oxido Ferroso"},
		{"NaCl", "Sal"}
	};

	public static string[,] bancoMalas = new string[,] {
		{"Basket", "Fut"},
		{"Americano", "Golf"},
		{"Boliche", "Frisbee"},
		{"Judo", "Karate"},
		{"Esgrima", "Clavados"},
		{"Canotaje", "Voleibol"}
	};
}
