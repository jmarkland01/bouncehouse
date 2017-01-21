using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
	private Animator myAnimator;

	// Use this for initialization
	void Start () {
		 myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonUp("Fire1"))
		{
			myAnimator.Play ("Shot");


	}
	}
}