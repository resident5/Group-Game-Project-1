using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {
	public Canvas infoMenu;
	public Canvas startMenu;
	public Text backText;


	// Use this for initialization
	void Start () {
		infoMenu = infoMenu.GetComponent<Canvas> ();
		backText = backText.GetComponent<Text> ();

		backText.enabled = false;
		infoMenu.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void information()
	{
		startMenu.enabled = false;
		infoMenu.enabled = true;
		backText.enabled = true;
	}

	public void goBack()
	{
		startMenu.enabled = true;
		backText.enabled = false;
		infoMenu.enabled = false;
	}

}
