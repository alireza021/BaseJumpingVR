using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Flying : MonoBehaviour {
	void OnTriggerEnter (Collider col){
		float speed = 90.0f;


		if (col.CompareTag ("Player")) {
			
			col.transform.position += col.transform.forward * Time.deltaTime * 90.0f;

			speed -= col.transform.forward.y * Time.deltaTime * 60.0f;
			col.transform.Rotate (Input.GetAxis ("Vertical"), 0.0f, -Input.GetAxis ("Horizontal"));

			float terrainHeightWhereWeAre = Terrain.activeTerrain.SampleHeight (col.transform.position);
			if (terrainHeightWhereWeAre > col.transform.position.y) {
				col.transform.position = new Vector3 (col.transform.position.x,
					terrainHeightWhereWeAre, col.transform.position.z);
		
		}
	
	}
}
}
