using UnityEngine;
using System.Collections;
using System;

public class InterfaceTable : MonoBehaviour {

	public Boolean reculeAppuye;
	public Boolean sauteAppuye;
	public Boolean avanceAppuye;
	public float speed = 0.3f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (avanceAppuye) {
			transform.Translate (new Vector3 (speed, 0, 0));
		}
		if (reculeAppuye) {
			transform.Translate (new Vector3 (-speed, 0, 0));
		}
		if (sauteAppuye) {
			transform.Translate (new Vector3 (0,speed, 0));
		}

	}

	public void MyFunction(string s)
	{
		string[] coordonnees;
		float[] xy = new float[2];
		coordonnees = s.Split (' ');
		xy[0] = Single.Parse(coordonnees[0]);
		xy[1] = Single.Parse(coordonnees[1]);

		if (Mathf.Sqrt((Mathf.Pow(2,xy[0] - 103)) + (Mathf.Pow(2,xy [1]- 72+930))) < 50)
		{
			transform.Translate(new Vector3(-0.4f,0,0));
		}
		if (Mathf.Sqrt((Mathf.Pow(2,xy[0] - 251)) + (Mathf.Pow(2,xy [1] - 72+930))) < 50)
		{
			transform.Translate(new Vector3(0.4f,0,0));
		}
		if (Mathf.Sqrt((Mathf.Pow(2,xy[0] - 1200)) + (Mathf.Pow(2,xy [1] - 72+930))) < 50)
		{
			transform.Translate(new Vector3(0,0.4f,0));
		}
			
	}

	public void Avance(string s)
	{
		
		if(s.Equals("Vrai"))
		{
			avanceAppuye = true;
		}
		if(s.Equals("Faux"))
		{
			avanceAppuye = false;
		}

	}

	public void Recule(string s)
	{
		if(s.Equals("Vrai"))
		{
			reculeAppuye = true;
		}
		if(s.Equals("Faux"))
		{
			reculeAppuye = false;
		}

	}

	public void Saute(string s)
	{
		if(s.Equals("Vrai"))
		{
			sauteAppuye = true;
		}
		if(s.Equals("Faux"))
		{
			sauteAppuye = false;
		}
	}
}
