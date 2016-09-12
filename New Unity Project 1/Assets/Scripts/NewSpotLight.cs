using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NewSpotLight : MonoBehaviour {

	public Light torchLight;
	public Text hudText;
	public static int counter = 0;

	void Awake(){
		hudText = GameObject.Find("Score").GetComponent<Text>();
	}

	void update(){

	}

	void OnTriggerEnter(){
		string hudInfo = "";

		if (torchLight.enabled == false) {
			torchLight.enabled = true;
			if (counter == 19)
				LoadLevel.gameToExit ();
			else
				counter++;
			hudInfo += "Score:"+ counter + "\n";
			hudText.text = hudInfo;
			print (counter);
		}
	}
}
