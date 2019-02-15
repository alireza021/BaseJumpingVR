using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		other.gameObject.transform.position += other.gameObject.transform.forward * Time.deltaTime * 90.0f;
	}
}
