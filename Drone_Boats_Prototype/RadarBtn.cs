using UnityEngine;
using System.Collections;

public class RadarBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI() {
		if (GUI.Button (new Rect (Screen.width/2+70,Screen.height - 70,100,50), "Jump!")){
			Application.LoadLevel(3);
		}
	}
}
