using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class test : MonoBehaviour {

	public GameObject animasyonPrefab;
	public GameObject panel;
	butonHedef hedef;




	public float ustSinir ;
	public float altSinir ;


	float animasyonBaslangicSuresi = 3.05f;
	float timeLeft = 8.05f;
   
	int sayac=0;

	static int dalgaSayisi;

	bool panelAktifmi =false;



	void Start () {

		hedef = new butonHedef();
		int degerD = hedef.getDogruDeger ();
		int degerY = hedef.getYanlisDeger ();

		GameObject.Find ("skorDogru").GetComponent<Text> ().text = string.Format ("{0,0}",degerD);
		GameObject.Find ("skorYanlis").GetComponent<Text> ().text = string.Format ("{0,0}",degerY);



		Invoke ("animasyonYarat", animasyonBaslangicSuresi);


	}

	void Update (){

		timeLeft -= Time.deltaTime;

		if (timeLeft < 0) {
			
			CancelInvoke ("animasyonYarat");

			if(sayac==0 )
				
			panelAktifmi = true;

		}

		if(panelAktifmi==true){
			
			Invoke ("panelCikis", 3f);
			panelAktifmi = false;
			sayac++;
		


		}
			
	}

	/**void baslangic(){

		GameObject animasyon = (GameObject)Instantiate (geriSayim,GameObject.Find("maincanvas").transform);


	}*/
	void panelCikis()
	{
		panel.SetActive (true);
	}


	void animasyonYarat () {



		setDalga("");

		Debug.Log (getDalga());

		Vector3 min = Camera.main.ViewportToScreenPoint (new Vector3 (-1, -1, 0));
		Vector3 max = Camera.main.ViewportToScreenPoint (new Vector3 (1, 1, 1));


		GameObject animasyon = (GameObject)Instantiate (animasyonPrefab, GameObject.Find ("maincanvas").transform);

		animasyon.transform.position = new Vector3 (Random.Range (min.x, max.x), Random.Range (min.y, max.y), max.z);

		sonrakiAnimasyonOlusturmaSuresi ();



	}

	void sonrakiAnimasyonOlusturmaSuresi(){

		float olusturmaSuresi;

		olusturmaSuresi = Random.Range (altSinir, ustSinir);


		Invoke ("animasyonYarat", olusturmaSuresi);

	}




	public void setDalga(string sifirla){


		if(sifirla=="sifirla"){

			dalgaSayisi = 0;

			

		}else{
			
			dalgaSayisi++;

		}

	}

	public  int getDalga(){

		return dalgaSayisi;
	}

	IEnumerator example(){


		yield return new WaitForSeconds(15f);

	}

}
