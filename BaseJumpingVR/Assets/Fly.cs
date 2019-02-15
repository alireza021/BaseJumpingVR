using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

	float speed = 10.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += transform.forward * Time.deltaTime * 12.0f;
		transform.position += transform.up * Time.deltaTime * -15.0f;

		speed -= transform.forward.y * Time.deltaTime * 40.0f;
		transform.Rotate (Input.GetAxis ("Vertical"), 0.0f, -Input.GetAxis ("Horizontal"));

		float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (transform.position);
		if (terrainHeightWhereWeAre > transform.position.y) {
			transform.position = new Vector3 (transform.position.x,
				terrainHeightWhereWeAre, transform.position.z);
	}


}
}
