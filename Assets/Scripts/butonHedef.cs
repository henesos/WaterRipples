using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class butonHedef : MonoBehaviour {

	test testN = new test ();
	oyunSkor skorN = new oyunSkor();

	public GameObject dogruAni;
	public GameObject yanlisAni;

	public GameObject yanlisSkor;
	public GameObject dogruSkor;



	int butonDeger , dalgaDeger;

	static int dogruDeger;
	static int yanlisDeger;



	public void degerKarsilastirma(){


		butonDeger= int.Parse (gameObject.name);

		dalgaDeger = testN.getDalga();

		Debug.Log (testN.getDalga());


		if(butonDeger==dalgaDeger){


			Instantiate (dogruAni, GameObject.Find ("maincanvas").transform);

			dogruDeger += 1;


			dogruSkor.GetComponent<Text>().text= string.Format("{0:0}",dogruDeger);

			Debug.Log ("dogru");



			
		
			testN.setDalga ("sifirla");
			GameObject.Find ("panelCanvas").SetActive(false);
			Invoke("oyunuBaslat",3f);



		}else{

			Instantiate (yanlisAni, GameObject.Find ("maincanvas").transform);

			yanlisDeger += 1;

			yanlisSkor.GetComponent<Text>().text= string.Format("{0:0}",yanlisDeger);

			testN.setDalga ("sifirla");
			GameObject.Find ("panelCanvas").SetActive(false);
			Invoke("oyunuBaslat",3f);

		}


	}

	public 	void oyunuBaslat () {



		switch(gameObject.tag){
		case "baslangic":
			SceneManager.LoadScene ("level1");
			break;
		case "cevap1":
			SceneManager.LoadScene ("level2");
			break;
		case "cevap2":
			SceneManager.LoadScene ("level3");
			break;
		case "cevap3":
			SceneManager.LoadScene ("level4");
			break;
		case "cevap4":
			SceneManager.LoadScene ("level5");
			break;
		case "cevap5":
			SceneManager.LoadScene ("level6");
			break;
		case "cevap6":
			SceneManager.LoadScene ("level7");
			break;
		case "cevap7":
			SceneManager.LoadScene ("level8");
			break;
		case "cevap8":
			SceneManager.LoadScene ("oyunSonu");
			break;

		}

	}


	public int getDogruDeger(){

		return dogruDeger;

	}

	public int getYanlisDeger(){

		return yanlisDeger;

	}

}
