using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Off : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

void OnTriggerEnter(Collider other) {
		
	if (other.gameObject.name == "Cube"){
			GetComponent<FirstPersonController>().enabled = false;
			GetComponent<CharacterController> ().enabled = false;
			GetComponent<Fly> ().enabled = true;

}
}
}