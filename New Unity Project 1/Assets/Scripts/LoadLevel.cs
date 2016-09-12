using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	//public int currentLevel = 1;

	public void titleToGame(){
		Application.LoadLevel ("Game mode");
	}

	public static void gameToExit(){
		Application.LoadLevel ("End");
	}
}
