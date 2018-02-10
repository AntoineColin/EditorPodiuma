using UnityEngine;
using System.Collections;

public class destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	void Update () {
	}
	// Destroy everything that enters the trigger
	void OnTriggerEnter2D(Collider2D oth) 
	{
		if (oth.gameObject.transform.tag == "Player") {
			Destroy(gameObject);

		}
	}
}