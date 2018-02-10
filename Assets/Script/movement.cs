using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {

	public float speed = 0.6f;
	public float high = 4.5f;
	private Rigidbody2D rb;
	private bool saut;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if (Input.GetKey (KeyCode.Space)){
			transform.Translate(new Vector3(0,speed,0));
		}
		if (Input.GetKey (KeyCode.D)){
			transform.Translate(new Vector3(speed,0,0));
		}
		if (Input.GetKey (KeyCode.Q)){
			transform.Translate(new Vector3(-speed,0,0));
		}
		*/

		rb.velocity = Vector2.Scale(rb.velocity , new Vector2(0,1));
		Vector2 move = new Vector2();
		if (Input.GetKeyDown (KeyCode.Space) && saut){
			rb.AddForce(new Vector2(0,high*500));
		}
		if (Input.GetKey (KeyCode.D)){
			move += new Vector2(1,0);
		}
		if (Input.GetKey (KeyCode.Q)){
			move += new Vector2(-1,0);
		}
		move = move * Time.deltaTime * speed *1000;
		rb.velocity += move;

	}

	public void haut()
	{
			transform.Translate(new Vector3(0,0.4f,0));
	}

	void OnTriggerEnter2D(Collider2D e){
		saut = true;
	}
	void OnTriggerExit2D(Collider2D e){
		saut = false;
	}
}
