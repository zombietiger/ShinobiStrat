using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Note: everything in this script should be project indeppendant.

public class ScreenManager : MonoBehaviour {

	private screenMethod currentCleanUp;
	private string currentScreenTag;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public delegate void screenMethod();

	public void drawScreen (screenMethod method, string tag) {
		//prep for screen change
		cleanScreen ();
		currentCleanUp = null;
		currentScreenTag = tag;
		//run delegate method
		method ();
	}

	public void drawScreen (screenMethod initMethod, screenMethod cleanUpMethod) {
		//prep for screen change
		cleanScreen ();
		currentCleanUp = cleanUpMethod;
		currentScreenTag = null;
		//run delegate method
		initMethod ();
	}

	private void cleanScreen () {
		if (currentCleanUp==null) {
			GameObject[] toDestroy = GameObject.FindGameObjectsWithTag(currentScreenTag);
			foreach (var item in toDestroy) {
				Destroy(item);	
			}
		} else {
			currentCleanUp();
		}
	}
}
