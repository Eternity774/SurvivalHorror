using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasRotate : MonoBehaviour {
	public float tilt, speed;
	private Vector3 target = new Vector3(0, 1.3f ,0);


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = Vector3.MoveTowards (transform.localPosition,target,speed*Time.deltaTime);
		if (transform.localPosition == target && target.y != 0.5f)
			target.y = 0.5f;
		else if (transform.localPosition == target && target.y == 0.5f)
			target.y = 1.3f;

		transform.Rotate (Vector3.up * tilt, Space.Self);
	}



}
