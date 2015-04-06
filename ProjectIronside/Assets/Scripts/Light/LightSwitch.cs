using UnityEngine;
using System.Collections;

public class LightSwitch : MonoBehaviour {

	private Light myLight;

	// Use this for initialization
	void Start () {
		myLight = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		myLight.enabled = !myLight.enabled;
	}
}
