using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpaceshipOscillate : MonoBehaviour {

	float height = 0.1f;
	Transform initial;
	public AnimationCurve myCurve;

	// Use this for initialization
	void Start () { 
		initial = transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition = new Vector3 (transform.localPosition.x, myCurve.Evaluate((Time.time %myCurve.length)), transform.localPosition.z);

	}


}
