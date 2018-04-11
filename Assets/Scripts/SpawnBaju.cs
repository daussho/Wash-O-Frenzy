using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBaju : MonoBehaviour {

	public GameObject[] bajuPrefab;
	public float spawnRate = 3f;
	public int bajuPoolSize = 10;

	private GameObject[] bajus;
	private int currentBaju = 0;

	private float spawnXPosition = 0f;
	private float spawnYPosition = 5f;
	//private Vector2 objectPoolPosition = new Vector2(spawnXPosition, spawnYPosition);

	private float timeSinceLastSpawned;

	// Use this for initialization
	void Start () {

		//Initialize the columns collection.
		bajus = new GameObject[bajuPoolSize];
		//Loop through the collection... 
		for(int i = 0; i < bajuPoolSize; i++)
		{
			//...and create the individual columns.
			int x = Random.Range(0,3);
			bajus[i] = (GameObject)Instantiate(bajuPrefab[x], new Vector2(spawnXPosition, 2+i*1), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	public void Spawn(){

		//Increase the value of currentColumn. If the new size is too big, set it back to zero
		if (currentBaju > bajuPoolSize) {
			currentBaju = 0;
		} else {
			currentBaju ++;
		}


	}
}
