using UnityEngine;
using System.Collections;

public abstract class Activate : MonoBehaviour {

	public enum keyColor{red,blue,green};
	public keyColor kc;
	protected SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = GetComponent<SpriteRenderer> ();
		switch(kc){
		case keyColor.red:
			sr.color = Color.red;
			Key.RedKey += Activater;
			break;
		case keyColor.blue:
			sr.color = Color.blue;
			Key.BlueKey += Activater;
			break;
		case keyColor.green:
			sr.color = Color.green;
			Key.GreenKey += Activater;
			break;
		default:
			break;
		}
	}
	
	public abstract void Activater ();
}
