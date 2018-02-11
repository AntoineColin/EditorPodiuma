using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D oth) 
	{

		if (oth.gameObject.transform.tag == "Respawn") {
			Application.LoadLevel ("Test");
			Debug.Log ("Recommencer");
		}

	}
}

