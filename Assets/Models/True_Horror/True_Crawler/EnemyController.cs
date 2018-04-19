using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {
	
	private Transform player;
	private float speed;
	private int i;
	private int buff_i;
	private GameObject[] waypoints;
	private int w_In;
	private Transform target;
	private bool way_on_off = true;
	public Canvas canv;

	// Use this for initialization
	void Start ()
	{
		canv = canv.GetComponent<Canvas> ();
		canv.enabled = false;
		w_In=0;
		waypoints = GameObject.FindGameObjectsWithTag ("Waypoints");
		player = GameObject.Find ("FPSController").transform;

	}

	
	// Update is called once per frame
	void Update () {
		if (way_on_off == true) {
			/***********************ДВИЖЕНИЕ МОНСТРА ПО ТОЧКАМ***********************/
			speed = 40f;
			for (i = 0; i < waypoints.Length; i++) {
				waypoints [i] = GameObject.Find ("w_Point" + i);
			}
			transform.LookAt (waypoints [w_In].transform.position);
			transform.position += transform.forward * speed * Time.deltaTime;
		} else if (way_on_off == false) {
			speed = 7f;
			if (Vector3.Distance (transform.position, player.transform.position) < 75) {
				transform.LookAt (player);
				transform.position += transform.forward * speed * Time.deltaTime;
			} else {
				way_on_off = true;
			}
		}
		/***********************ДВИЖЕНИЕ МОНСТРА ПО ТОЧКАМ***********************/
	}



	/************************КОЛЛИЗИЯ КОЛЛАЙДЕРОВ**********************/
	void OnCollisionEnter (Collision col){
		
		/********************ЛАПОЙ ПО ИГРОКУ - СМЕРТЬ**********************/
		if (col.collider.tag == "Player") {
			canv.enabled = true;
			Debug.Log ("You died");
		}

		/*******************ПЕРЕХОД НА СЛЕДУЮЩИЙ ВЕЙПОИНТ******************/
		if (col.collider.tag == "Waypoints") {
			w_In++;
			if (w_In == 19) {
				w_In = 0;
			}
		}
	}
	/***************ПЕРЕХОД С МАРШРУТА НА ИГРОКА И ОБРАТНО******************/
	void OnTriggerEnter (Collider col){
		if (col.tag == "Player") {
			way_on_off = false;
		}
	}

//	void OnTriggerExit (Collider col){
//		if (col.tag == "Player") {
//			way_on_off = true;
//		}
//	}
}