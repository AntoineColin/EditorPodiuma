using UnityEngine;
using System.Collections;

public class Activatedoor : Activate {


	public override void Activater ()
	{
		Color n = sr.color;
		n.a = 0.3f;
		sr.color = n;
		GetComponent<Collider2D> ().enabled = false;
	}
}
