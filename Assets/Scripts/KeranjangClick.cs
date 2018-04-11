using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeranjangClick : MonoBehaviour {

	private static GameObject[] baju;
	private static int x;
	private static int i = 0;

	// Use this for initialization
	void Start () {
		
		baju = GameObject.FindGameObjectsWithTag("ArrayBaju");
		x = baju.Length;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Clicked(int id){
		if (i < x) {
			if (baju [i].GetComponent<ObjectIdentity> ().GetID () == id) {
				GameControl.instance.PlayerScored ();
			}
		} else {
			i = 0;
		}
		Destroy(baju[i]);
		i++;

	}
}
