using UnityEngine;
using System.Collections;

//6.4, -5

public class MasterController : MonoBehaviour {

	Component screenManager;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<ScreenManager> ().drawScreen (startScreenInit,startScreenClean);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startScreenInit () {
		gameObject.AddComponent<StartScreenGUI> ();
	}

	public void startScreenClean () {
		Destroy (gameObject.GetComponent<StartScreenGUI>());
	}

	public void buildCharacterScreenInit () {
		gameObject.AddComponent<BuildCharacterScreen> ();
	}

	public void buildCharacterScreenClean () {
		Destroy (gameObject.GetComponent<BuildCharacterScreen>());
	}
}
