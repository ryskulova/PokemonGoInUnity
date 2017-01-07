using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenes : MonoBehaviour {
	public void mySwitchScenes(string BasicLoader){
		Application.LoadLevel (BasicLoader);
	}
}
