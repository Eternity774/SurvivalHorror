﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Canvas quitmenu;
	public Button startText;
	public Button exitText;
	public Text startText1;
	public Text exitText1;
	//public Canvas BG;
	// Use this for initialization
	void Start () {

		quitmenu = quitmenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		startText1 = startText.GetComponent<Text> ();
		exitText = exitText.GetComponent<Button> ();
		exitText1 = exitText.GetComponent<Text> ();
		//BG = BG.GetComponent<Canvas> ();
		quitmenu.enabled = false;
	}

	public void ExitPress()
	{
		quitmenu.enabled = true;
		startText.enabled = false;
		startText1.enabled = false;
		exitText.enabled = false;
		exitText1.enabled = false;



	}
	public void NoPress(){
		quitmenu.enabled = false;
		startText.enabled = true;
		startText1.enabled = true;
		exitText.enabled = true;
		exitText1.enabled = true;
	}
	public void StartLevel(){
		Application.LoadLevel ("MainScene");
		}
	public void ExitGame(){
		Application.Quit ();
	}
}
