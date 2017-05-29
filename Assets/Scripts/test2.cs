using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour {

public float minSpawnTime = 3.0f;
public float maxSpawnTime = 5.0f;
public float distFromCamera = 10.0f;

private float timer = 0.0f;
private float nextTime;

	public GameObject prefab;

void Start () {
		
	nextTime = Random.Range(minSpawnTime, maxSpawnTime);  

}

void Update () {
		
	timer += Time.deltaTime;

	if (timer > nextTime) {
			
		Vector3 pos = new Vector3(Random.value, Random.value, distFromCamera);
		
		pos = Camera.main.ViewportToWorldPoint(pos);

		Instantiate(prefab, pos, Quaternion.identity);

		Debug.Log("Object created");

		timer = 0.0f;
		nextTime = Random.Range(minSpawnTime, maxSpawnTime);

	}

}

}