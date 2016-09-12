using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {
	public GameObject player;
	public LoadLevel script;
	
	void OnTriggerEnter()
	{		
		NewSpotLight.counter = 0;
		Application.LoadLevel("Game Mode");
		//player.transform.position = Vector3 (-0.3, 1, 8.8);
	}
}
