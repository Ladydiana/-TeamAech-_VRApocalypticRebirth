using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipTranslate : MonoBehaviour {


	Transform initial;

	// Use this for initialization
	void Start () { 
		initial = transform;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.localPosition = new Vector3 (myCurve.Evaluate((Time.time %myCurve.length)), transform.localPosition.y, transform.localPosition.z);
		transform.localPosition += Vector3.left * Time.deltaTime;
	}

}
