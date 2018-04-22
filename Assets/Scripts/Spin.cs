using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	private static int speed = 0;


	void Update ()
	{
		transform.Rotate(Vector3.back, speed * Time.deltaTime);
	}

	public void UpSpeed(){
		speed += Random.Range(0, 100);
	}

	public void DownSpeed(){
		speed -= Random.Range(0, 100);;
	}
}