using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public static GameManager.collectable RedKey, BlueKey, GreenKey;
	private Key redInstance, blueInstance, greenInstance;
	public enum keyColor{red,blue,green};
	public keyColor currentColor;
	protected SpriteRenderer sr;

	void Start(){
		sr = GetComponent<SpriteRenderer> ();
		switch(currentColor){
		case keyColor.red:
			sr.color = Color.red;
			break;
		case keyColor.blue:
			sr.color = Color.blue;
			break;
		case keyColor.green:
			sr.color = Color.green;
			break;
		}
	}
	void OnTriggerEnter2D(Collider2D coll){
		
		if (coll != null && coll.gameObject.tag == "Player") {
			if (currentColor == keyColor.red) {
				if(GreenKey!=null)
					RedKey ();
			} else if (currentColor == keyColor.blue) {
				if(GreenKey!=null)
					BlueKey ();
			} else {
				if(GreenKey!=null)
					GreenKey ();
			}
			Destroy (gameObject);
		}
	}
}
