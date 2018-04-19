using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawanimation : MonoBehaviour {
	public Animator anim1;
	// Use this for initialization
	void Start () {
		anim1 = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider col){
		if (col.tag == "Player") {
			anim1.SetTrigger ("Enter");
		}
	}
	void OnTriggerExit(Collider col){
		if (col.tag == "Player") {
			anim1.SetTrigger ("Exit");
		}
	}


}
