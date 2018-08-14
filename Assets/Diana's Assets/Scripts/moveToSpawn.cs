using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToSpawn : MonoBehaviour {

	public GameObject editorEmulator;
	public GameObject DianaGameObject;
	public GameObject spawnLocation;
	public AudioClip futureMusic;
	public GameObject ApocalypticGameObject;
	public GameObject pickupSpawners;

	// Update is called once per frame
	void Update () {
		if (DianaGameObject != null && DianaGameObject.activeInHierarchy && ApocalypticGameObject.activeInHierarchy) {
			//Debug.Log ("We got here");
			ApocalypticGameObject.SetActive (false);
			pickupSpawners.SetActive (false);
			AudioSource previousMusic = editorEmulator.GetComponentInChildren<AudioSource>();
			previousMusic.Pause ();
			editorEmulator.GetComponentInChildren<AudioSource> ().clip = futureMusic;
			editorEmulator.GetComponentInChildren<AudioSource> ().loop = true;
			editorEmulator.GetComponentInChildren<AudioSource> ().Play();
			//futureMusic.GetComponent<AudioSource>() .Play ();

			if (editorEmulator != null && spawnLocation!=null) {
				editorEmulator.transform.position = spawnLocation.transform.position;
			}
		}
	}
}
