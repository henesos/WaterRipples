using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class son : MonoBehaviour {

	public Text SayacText;
	butonHedef hedef;
	sayac sure;

	void Start () {

		hedef = new butonHedef();
		sure = new sayac ();
		int degerD = hedef.getDogruDeger ();
		int degerY = hedef.getYanlisDeger ();

		GameObject.Find ("skorDogru").GetComponent<Text> ().text = string.Format ("{0,0}",degerD);
		GameObject.Find ("skorYanlis").GetComponent<Text> ().text = string.Format ("{0,0}",degerY);

		SayacText.text=" "+Mathf.RoundToInt(sure.getDakika()).ToString("D2") + ":"+Mathf.RoundToInt(sure.getSaniye()).ToString("D2");



		
	}
	

}
