using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject Person;
	public Text hudText;


	void Awake () {
		for (int i = 0; i < 50; i++) {
			Vector3 position = new Vector3 (Random.Range (62, -62), 0.49f, Random.Range (62, -62));
			Instantiate (Person, position, Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {

	}

}
