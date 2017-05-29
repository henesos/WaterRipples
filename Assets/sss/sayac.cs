using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sayac : MonoBehaviour {

    public Text SayacText;

     public static float saniye, dakika;




	void Update () {
        saniye += Time.deltaTime;
        if(Mathf.RoundToInt(saniye)>59)
        {
            saniye = 0;
            dakika++;
		}

        SayacText.text = " "+Mathf.RoundToInt(dakika).ToString("D2") + ":"+Mathf.RoundToInt(saniye).ToString("D2");



    }

	public float getSaniye(){

		return saniye;
	}

	public float getDakika(){

		return dakika;
	}



}
