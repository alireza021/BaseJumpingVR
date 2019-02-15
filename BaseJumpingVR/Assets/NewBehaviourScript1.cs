using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	float speed = 90.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * 20.0f;

		speed -= transform.forward.y * Time.deltaTime * 60.0f;
		transform.Rotate (Input.GetAxis ("Vertical"), 0.0f, -Input.GetAxis ("Horizontal"));

		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (transform.position);
		if (terrainHeightWhereWeAre > transform.position.y) {
			transform.position = new Vector3 (transform.position.x,
				terrainHeightWhereWeAre, transform.position.z);
		}
	}
}
