using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject ground;
	private bool walking = false;
	
	// Update is called once per frame
	void Update () {
		if (walking) {
			transform.position = transform.position + Camera.main.transform.forward * 2.0f * Time.deltaTime;
		}

		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (.5f, .5f, 0));
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit)) {
			//Debug.Log ("I'm looking at " + hit.transform.name);
			if (hit.collider.name.Contains ("Terrain")) {
				if (hit.distance <=5) {
					walking = false;
				}
			} else {
				walking = true;
			}
		} else {
			//Debug.Log ("I'm looking at the horizon.");
			walking = true;
		}
	}
}
