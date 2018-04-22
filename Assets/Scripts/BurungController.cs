using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurungController : MonoBehaviour {

    public static float timeToFire = 0;
    public static float maxTime = 10f;         //total time of the game
    public static int timesFlying = 3;         //the amount of the bird showing up

    float poopEvery;
    float[] poopTime = new float[timesFlying];
    
    // Use this for initialization
    void Start () {
        poopEvery = maxTime / timesFlying;    
        for (int i = 0; i < timesFlying; i++)
        {
            poopTime[i] = Time.time + poopEvery * i;
        }
	}
	
	// Update is called once per frame
	void Update () {
        int i = 0;
        while (i<timesFlying) {
            if (Time.time == poopTime[i])
            {
                Poop();
                i++;
            }
        }
	}

    void Poop()
    {
        Debug.Log("Pooping right now");
    }
}
